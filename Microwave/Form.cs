using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave
{
    public enum isAction
    {
        isStart,
        isStop,
        isPause
    }
    public partial class Form : System.Windows.Forms.Form
    {
        Microwave microwave;
        Thread thread;
        isAction Action;
        ManualResetEvent me;
        bool isOpened;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;

        public Form()
        {
            InitializeComponent();
            Action = isAction.isStop;
            microwave = new Microwave(this);
            lblTimer.Text = microwave.TimePowerUpdate();
            isOpened = false;

            byte[] fontData = Properties.Resources.LCDM2N;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.LCDM2N.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.LCDM2N.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 12.0F);

            lblTimer.Font = myFont;
        }

        private void btnTimeUp10_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int second = 10;
            microwave.ChangeTime(second);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnTimeDown10_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int second = -10;
            microwave.ChangeTime(second);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnTimeUp30_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int second = 30;
            microwave.ChangeTime(second);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnTimeDown30_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int second = -30;
            microwave.ChangeTime(second);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnTimeUp60_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int second = 60;
            microwave.ChangeTime(second);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnTimeDown60_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int second = -60;
            microwave.ChangeTime(second);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnPowerDown_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int power = -100;
            microwave.ChangePower(power);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnPowerUp_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            int power = 100;
            microwave.ChangePower(power);
            lblTimer.Text = microwave.TimePowerUpdate();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (microwave.Time.TotalSeconds == 0)
                return;
            if (Action == isAction.isStop)
            {
                Action = isAction.isStart;
                thread = new Thread(StartTimer);
                me = new ManualResetEvent(true);
                thread.Start(me);
            }
            if (Action == isAction.isPause)
            {
                Action = isAction.isStart;
                me.Set();
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (Action == isAction.isStart || Action == isAction.isPause)
            {
                Action = isAction.isStop;
                me.Reset();
                microwave.Time = new TimeSpan(0, 0, 0);
                lblTimer.Text = microwave.TimePowerUpdate();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (Action == isAction.isStart)
            {
                Action = isAction.isPause;
                me.Reset();
            }
        }

        delegate void Del(string text);

        public void StartTimer(object state)
        {
            ManualResetEvent MRE = (ManualResetEvent)state;
            Color color = Color.Black;
            while (true)
            {
                MRE.WaitOne();
                if (microwave.Time.TotalSeconds == 0)
                {
                    Console.Beep(4000, 250);
                    Console.Beep(4000, 250);
                    Thread.Sleep(1000);
                    Console.Beep(4000, 250);
                    Console.Beep(4000, 250);
                    Action = isAction.isStop;
                    break;
                }

                microwave.Time = microwave.Time.Add(new TimeSpan(0, 0, -1));
                //lblTimer.Text = microwave.TimePowerUpdate();
                string str = microwave.TimePowerUpdate();

                if (color == Color.Red)
                    color = Color.Black;
                else
                    color = Color.Red;

                lblTimer.Invoke(new Del((s) => lblTimer.ForeColor = color), "newText");
                lblTimer.Invoke(new Del((s) => lblTimer.Text = str), "newText");
                Thread.Sleep(500);

                if (color == Color.Red)
                    color = Color.Black;
                else
                    color = Color.Red;

                lblTimer.Invoke(new Del((s) => lblTimer.ForeColor = color), "newText");
                Thread.Sleep(500);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            isOpened = !isOpened;
            if (isOpened == true)
            {
                panelOpened.Visible = true;
                btnOpen.Text = "Закрыть";
            }
            else
            {
                panelOpened.Visible = false;
                btnOpen.Text = "Открыть";
            }

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
