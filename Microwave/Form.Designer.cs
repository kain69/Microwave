
namespace Microwave
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tablePower = new System.Windows.Forms.TableLayoutPanel();
            this.btnPowerUp = new System.Windows.Forms.Button();
            this.btnPowerDown = new System.Windows.Forms.Button();
            this.tableTime = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimeDown60 = new System.Windows.Forms.Button();
            this.btnTimeDown30 = new System.Windows.Forms.Button();
            this.btnTimeDown10 = new System.Windows.Forms.Button();
            this.btnTimeUp60 = new System.Windows.Forms.Button();
            this.btnTimeUp30 = new System.Windows.Forms.Button();
            this.btnTimeUp10 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panelOpened = new System.Windows.Forms.Panel();
            this.lblOpenStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableOption.SuspendLayout();
            this.tablePower.SuspendLayout();
            this.tableTime.SuspendLayout();
            this.panelOpened.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.panelOpened);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(784, 461);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.tableOption);
            this.panelRight.Controls.Add(this.tablePower);
            this.panelRight.Controls.Add(this.tableTime);
            this.panelRight.Controls.Add(this.lblTimer);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(585, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(199, 461);
            this.panelRight.TabIndex = 1;
            // 
            // tableOption
            // 
            this.tableOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOption.ColumnCount = 2;
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOption.Controls.Add(this.btnOpen, 0, 1);
            this.tableOption.Controls.Add(this.btnPause, 0, 0);
            this.tableOption.Controls.Add(this.btnStart, 0, 0);
            this.tableOption.Controls.Add(this.btnStop, 0, 0);
            this.tableOption.Location = new System.Drawing.Point(3, 332);
            this.tableOption.Name = "tableOption";
            this.tableOption.RowCount = 2;
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOption.Size = new System.Drawing.Size(191, 100);
            this.tableOption.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Location = new System.Drawing.Point(98, 53);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 44);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.TabStop = false;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(3, 53);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(89, 44);
            this.btnPause.TabIndex = 8;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 44);
            this.btnStart.TabIndex = 7;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(98, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 44);
            this.btnStop.TabIndex = 6;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tablePower
            // 
            this.tablePower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePower.ColumnCount = 2;
            this.tablePower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePower.Controls.Add(this.btnPowerUp, 0, 0);
            this.tablePower.Controls.Add(this.btnPowerDown, 0, 0);
            this.tablePower.Location = new System.Drawing.Point(3, 104);
            this.tablePower.Name = "tablePower";
            this.tablePower.RowCount = 1;
            this.tablePower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tablePower.Size = new System.Drawing.Size(191, 43);
            this.tablePower.TabIndex = 3;
            // 
            // btnPowerUp
            // 
            this.btnPowerUp.BackColor = System.Drawing.Color.White;
            this.btnPowerUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPowerUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPowerUp.Location = new System.Drawing.Point(98, 3);
            this.btnPowerUp.Name = "btnPowerUp";
            this.btnPowerUp.Size = new System.Drawing.Size(90, 37);
            this.btnPowerUp.TabIndex = 5;
            this.btnPowerUp.TabStop = false;
            this.btnPowerUp.Text = "+ 100 w";
            this.btnPowerUp.UseVisualStyleBackColor = true;
            this.btnPowerUp.Click += new System.EventHandler(this.btnPowerUp_Click);
            // 
            // btnPowerDown
            // 
            this.btnPowerDown.BackColor = System.Drawing.Color.White;
            this.btnPowerDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPowerDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPowerDown.Location = new System.Drawing.Point(3, 3);
            this.btnPowerDown.Name = "btnPowerDown";
            this.btnPowerDown.Size = new System.Drawing.Size(89, 37);
            this.btnPowerDown.TabIndex = 4;
            this.btnPowerDown.TabStop = false;
            this.btnPowerDown.Text = "- 100 w";
            this.btnPowerDown.UseVisualStyleBackColor = true;
            this.btnPowerDown.Click += new System.EventHandler(this.btnPowerDown_Click);
            // 
            // tableTime
            // 
            this.tableTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTime.ColumnCount = 3;
            this.tableTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableTime.Controls.Add(this.btnTimeDown60, 2, 1);
            this.tableTime.Controls.Add(this.btnTimeDown30, 1, 1);
            this.tableTime.Controls.Add(this.btnTimeDown10, 0, 1);
            this.tableTime.Controls.Add(this.btnTimeUp60, 2, 0);
            this.tableTime.Controls.Add(this.btnTimeUp30, 1, 0);
            this.tableTime.Controls.Add(this.btnTimeUp10, 0, 0);
            this.tableTime.Location = new System.Drawing.Point(3, 177);
            this.tableTime.Name = "tableTime";
            this.tableTime.RowCount = 2;
            this.tableTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTime.Size = new System.Drawing.Size(191, 124);
            this.tableTime.TabIndex = 1;
            // 
            // btnTimeDown60
            // 
            this.btnTimeDown60.BackColor = System.Drawing.Color.White;
            this.btnTimeDown60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeDown60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeDown60.Location = new System.Drawing.Point(129, 64);
            this.btnTimeDown60.Name = "btnTimeDown60";
            this.btnTimeDown60.Size = new System.Drawing.Size(59, 57);
            this.btnTimeDown60.TabIndex = 5;
            this.btnTimeDown60.TabStop = false;
            this.btnTimeDown60.Text = "- 1 мин";
            this.btnTimeDown60.UseVisualStyleBackColor = true;
            this.btnTimeDown60.Click += new System.EventHandler(this.btnTimeDown60_Click);
            // 
            // btnTimeDown30
            // 
            this.btnTimeDown30.BackColor = System.Drawing.Color.White;
            this.btnTimeDown30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeDown30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeDown30.Location = new System.Drawing.Point(66, 64);
            this.btnTimeDown30.Name = "btnTimeDown30";
            this.btnTimeDown30.Size = new System.Drawing.Size(57, 57);
            this.btnTimeDown30.TabIndex = 4;
            this.btnTimeDown30.TabStop = false;
            this.btnTimeDown30.Text = "- 30 сек";
            this.btnTimeDown30.UseVisualStyleBackColor = true;
            this.btnTimeDown30.Click += new System.EventHandler(this.btnTimeDown30_Click);
            // 
            // btnTimeDown10
            // 
            this.btnTimeDown10.BackColor = System.Drawing.Color.White;
            this.btnTimeDown10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeDown10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeDown10.Location = new System.Drawing.Point(3, 64);
            this.btnTimeDown10.Name = "btnTimeDown10";
            this.btnTimeDown10.Size = new System.Drawing.Size(57, 57);
            this.btnTimeDown10.TabIndex = 3;
            this.btnTimeDown10.TabStop = false;
            this.btnTimeDown10.Text = "-10 сек";
            this.btnTimeDown10.UseVisualStyleBackColor = true;
            this.btnTimeDown10.Click += new System.EventHandler(this.btnTimeDown10_Click);
            // 
            // btnTimeUp60
            // 
            this.btnTimeUp60.BackColor = System.Drawing.Color.White;
            this.btnTimeUp60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeUp60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeUp60.Location = new System.Drawing.Point(129, 3);
            this.btnTimeUp60.Name = "btnTimeUp60";
            this.btnTimeUp60.Size = new System.Drawing.Size(59, 55);
            this.btnTimeUp60.TabIndex = 2;
            this.btnTimeUp60.TabStop = false;
            this.btnTimeUp60.Text = "+1 мин";
            this.btnTimeUp60.UseVisualStyleBackColor = true;
            this.btnTimeUp60.Click += new System.EventHandler(this.btnTimeUp60_Click);
            // 
            // btnTimeUp30
            // 
            this.btnTimeUp30.BackColor = System.Drawing.Color.White;
            this.btnTimeUp30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeUp30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeUp30.Location = new System.Drawing.Point(66, 3);
            this.btnTimeUp30.Name = "btnTimeUp30";
            this.btnTimeUp30.Size = new System.Drawing.Size(57, 55);
            this.btnTimeUp30.TabIndex = 1;
            this.btnTimeUp30.TabStop = false;
            this.btnTimeUp30.Text = "+30 сек";
            this.btnTimeUp30.UseVisualStyleBackColor = true;
            this.btnTimeUp30.Click += new System.EventHandler(this.btnTimeUp30_Click);
            // 
            // btnTimeUp10
            // 
            this.btnTimeUp10.BackColor = System.Drawing.Color.White;
            this.btnTimeUp10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeUp10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeUp10.Location = new System.Drawing.Point(3, 3);
            this.btnTimeUp10.Name = "btnTimeUp10";
            this.btnTimeUp10.Size = new System.Drawing.Size(57, 55);
            this.btnTimeUp10.TabIndex = 0;
            this.btnTimeUp10.TabStop = false;
            this.btnTimeUp10.Text = "+10 сек";
            this.btnTimeUp10.UseVisualStyleBackColor = true;
            this.btnTimeUp10.Click += new System.EventHandler(this.btnTimeUp10_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(3, 7);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(191, 65);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Time: 5:00\r\n\r\nPower: 100 w";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelOpened
            // 
            this.panelOpened.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpened.BackColor = System.Drawing.Color.Gray;
            this.panelOpened.Controls.Add(this.lblOpenStatus);
            this.panelOpened.Location = new System.Drawing.Point(11, 11);
            this.panelOpened.Name = "panelOpened";
            this.panelOpened.Size = new System.Drawing.Size(567, 437);
            this.panelOpened.TabIndex = 0;
            this.panelOpened.Visible = false;
            // 
            // lblOpenStatus
            // 
            this.lblOpenStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpenStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpenStatus.Location = new System.Drawing.Point(0, 0);
            this.lblOpenStatus.Name = "lblOpenStatus";
            this.lblOpenStatus.Size = new System.Drawing.Size(567, 437);
            this.lblOpenStatus.TabIndex = 0;
            this.lblOpenStatus.Text = "Открыто";
            this.lblOpenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Мощность:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 155);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Опции:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кармазин Влад ФИТ-3 Микроволновка";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tableOption.ResumeLayout(false);
            this.tablePower.ResumeLayout(false);
            this.tableTime.ResumeLayout(false);
            this.panelOpened.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TableLayoutPanel tablePower;
        private System.Windows.Forms.Button btnTimeUp10;
        private System.Windows.Forms.Button btnPowerUp;
        private System.Windows.Forms.Button btnPowerDown;
        private System.Windows.Forms.Button btnTimeDown60;
        private System.Windows.Forms.Button btnTimeDown30;
        private System.Windows.Forms.Button btnTimeDown10;
        private System.Windows.Forms.Button btnTimeUp60;
        private System.Windows.Forms.Button btnTimeUp30;
        private System.Windows.Forms.TableLayoutPanel tableOption;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panelOpened;
        private System.Windows.Forms.Label lblOpenStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

