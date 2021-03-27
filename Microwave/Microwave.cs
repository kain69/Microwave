using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Microwave
{
    class Microwave
    {
        public TimeSpan Time { get; set; }
        public int Power { get; private set; }
        public string TimeAndPower { get; private set; }
        Form form;


        public Microwave(Form form)
        {
            Time = new TimeSpan(0,0,0);
            Power = 800;
            TimePowerUpdate();
            this.form = form;
        }

        public string TimePowerUpdate()
        {
            TimeAndPower = $"Time: {Time:mm':'ss}\n\nPower: {Power} W";
            return TimeAndPower;
        }

        public void ChangeTime(int second)
        {
            if (second < 0 && Time.TotalSeconds + second <= 0)
            {
                Time = new TimeSpan(0, 0, 0);
                return;
            }
                
            if (second > 0 && Time.TotalSeconds >= 3599)
            {
                Time = new TimeSpan(0,59, 59);
                return;
            }
            Time = Time.Add(new TimeSpan(0, 0, second));
        }

        public void ChangePower(int power)
        {
            if (power < 0 && Power <= 100) 
            { 
                Power = 100;
                return;
            }
            if (power > 0 && Power >= 800)
            {
                Power = 800;
                return;
            }
            Power += power;
        }
    }
}
