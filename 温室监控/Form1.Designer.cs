namespace 温室监控
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanle = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start = new HZH_Controls.Controls.UCBtnExt();
            this.cmb_serialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Them1 = new HZH_Controls.Controls.UCThermometer();
            this.ucledNums1 = new HZH_Controls.Controls.UCLEDNums();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LED7 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt7 = new HZH_Controls.Controls.UCSwitch();
            this.LED6 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt6 = new HZH_Controls.Controls.UCSwitch();
            this.LED5 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt5 = new HZH_Controls.Controls.UCSwitch();
            this.LED4 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt4 = new HZH_Controls.Controls.UCSwitch();
            this.LED3 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt3 = new HZH_Controls.Controls.UCSwitch();
            this.LED2 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt2 = new HZH_Controls.Controls.UCSwitch();
            this.LED1 = new HZH_Controls.Controls.UCSignalLamp();
            this.LEDSwt1 = new HZH_Controls.Controls.UCSwitch();
            this.leftPanle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanle
            // 
            this.leftPanle.BackColor = System.Drawing.Color.White;
            this.leftPanle.Controls.Add(this.groupBox1);
            this.leftPanle.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanle.Location = new System.Drawing.Point(0, 0);
            this.leftPanle.Name = "leftPanle";
            this.leftPanle.Size = new System.Drawing.Size(260, 673);
            this.leftPanle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.cmb_serialPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备控制";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.BtnBackColor = System.Drawing.Color.White;
            this.btn_start.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.BtnForeColor = System.Drawing.Color.White;
            this.btn_start.BtnText = "启动";
            this.btn_start.ConerRadius = 10;
            this.btn_start.EnabledMouseEffect = false;
            this.btn_start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(93)))));
            this.btn_start.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_start.IsRadius = true;
            this.btn_start.IsShowRect = true;
            this.btn_start.IsShowTips = false;
            this.btn_start.Location = new System.Drawing.Point(99, 70);
            this.btn_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start.Name = "btn_start";
            this.btn_start.RectColor = System.Drawing.Color.White;
            this.btn_start.RectWidth = 1;
            this.btn_start.Size = new System.Drawing.Size(148, 40);
            this.btn_start.TabIndex = 2;
            this.btn_start.TabStop = false;
            this.btn_start.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_start.TipsText = "";
            this.btn_start.BtnClick += new System.EventHandler(this.btn_start_BtnClick);
            // 
            // cmb_serialPort
            // 
            this.cmb_serialPort.FormattingEnabled = true;
            this.cmb_serialPort.Location = new System.Drawing.Point(99, 26);
            this.cmb_serialPort.Name = "cmb_serialPort";
            this.cmb_serialPort.Size = new System.Drawing.Size(151, 28);
            this.cmb_serialPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号：";
            // 
            // Them1
            // 
            this.Them1.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.Them1.LeftTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.Them1.Location = new System.Drawing.Point(301, 69);
            this.Them1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Them1.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.Them1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Them1.Name = "Them1";
            this.Them1.RightTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.F;
            this.Them1.Size = new System.Drawing.Size(88, 392);
            this.Them1.SplitCount = 5;
            this.Them1.TabIndex = 1;
            this.Them1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ucledNums1
            // 
            this.ucledNums1.LineWidth = 8;
            this.ucledNums1.Location = new System.Drawing.Point(396, 396);
            this.ucledNums1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucledNums1.Name = "ucledNums1";
            this.ucledNums1.Size = new System.Drawing.Size(204, 65);
            this.ucledNums1.TabIndex = 2;
            this.ucledNums1.Value = "66.66";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LED7);
            this.groupBox2.Controls.Add(this.LEDSwt7);
            this.groupBox2.Controls.Add(this.LED6);
            this.groupBox2.Controls.Add(this.LEDSwt6);
            this.groupBox2.Controls.Add(this.LED5);
            this.groupBox2.Controls.Add(this.LEDSwt5);
            this.groupBox2.Controls.Add(this.LED4);
            this.groupBox2.Controls.Add(this.LEDSwt4);
            this.groupBox2.Controls.Add(this.LED3);
            this.groupBox2.Controls.Add(this.LEDSwt3);
            this.groupBox2.Controls.Add(this.LED2);
            this.groupBox2.Controls.Add(this.LEDSwt2);
            this.groupBox2.Controls.Add(this.LED1);
            this.groupBox2.Controls.Add(this.LEDSwt1);
            this.groupBox2.Location = new System.Drawing.Point(549, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P2LED";
            // 
            // LED7
            // 
            this.LED7.IsHighlight = true;
            this.LED7.IsShowBorder = false;
            this.LED7.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED7.Location = new System.Drawing.Point(585, 39);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(57, 57);
            this.LED7.TabIndex = 3;
            this.LED7.TwinkleSpeed = 0;
            // 
            // LEDSwt7
            // 
            this.LEDSwt7.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt7.Checked = false;
            this.LEDSwt7.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt7.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt7.Location = new System.Drawing.Point(589, 123);
            this.LEDSwt7.Name = "LEDSwt7";
            this.LEDSwt7.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt7.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt7.TabIndex = 2;
            this.LEDSwt7.Texts = null;
            this.LEDSwt7.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt7.TrueTextColr = System.Drawing.Color.White;
            // 
            // LED6
            // 
            this.LED6.IsHighlight = true;
            this.LED6.IsShowBorder = false;
            this.LED6.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED6.Location = new System.Drawing.Point(497, 39);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(57, 57);
            this.LED6.TabIndex = 3;
            this.LED6.TwinkleSpeed = 0;
            // 
            // LEDSwt6
            // 
            this.LEDSwt6.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt6.Checked = false;
            this.LEDSwt6.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt6.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt6.Location = new System.Drawing.Point(501, 123);
            this.LEDSwt6.Name = "LEDSwt6";
            this.LEDSwt6.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt6.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt6.TabIndex = 2;
            this.LEDSwt6.Texts = null;
            this.LEDSwt6.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt6.TrueTextColr = System.Drawing.Color.White;
            // 
            // LED5
            // 
            this.LED5.IsHighlight = true;
            this.LED5.IsShowBorder = false;
            this.LED5.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED5.Location = new System.Drawing.Point(409, 39);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(57, 57);
            this.LED5.TabIndex = 3;
            this.LED5.TwinkleSpeed = 0;
            // 
            // LEDSwt5
            // 
            this.LEDSwt5.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt5.Checked = false;
            this.LEDSwt5.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt5.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt5.Location = new System.Drawing.Point(413, 123);
            this.LEDSwt5.Name = "LEDSwt5";
            this.LEDSwt5.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt5.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt5.TabIndex = 2;
            this.LEDSwt5.Texts = null;
            this.LEDSwt5.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt5.TrueTextColr = System.Drawing.Color.White;
            // 
            // LED4
            // 
            this.LED4.IsHighlight = true;
            this.LED4.IsShowBorder = false;
            this.LED4.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED4.Location = new System.Drawing.Point(321, 39);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(57, 57);
            this.LED4.TabIndex = 3;
            this.LED4.TwinkleSpeed = 0;
            // 
            // LEDSwt4
            // 
            this.LEDSwt4.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt4.Checked = false;
            this.LEDSwt4.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt4.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt4.Location = new System.Drawing.Point(325, 123);
            this.LEDSwt4.Name = "LEDSwt4";
            this.LEDSwt4.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt4.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt4.TabIndex = 2;
            this.LEDSwt4.Texts = null;
            this.LEDSwt4.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt4.TrueTextColr = System.Drawing.Color.White;
            // 
            // LED3
            // 
            this.LED3.IsHighlight = true;
            this.LED3.IsShowBorder = false;
            this.LED3.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED3.Location = new System.Drawing.Point(233, 40);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(57, 57);
            this.LED3.TabIndex = 3;
            this.LED3.TwinkleSpeed = 0;
            // 
            // LEDSwt3
            // 
            this.LEDSwt3.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt3.Checked = false;
            this.LEDSwt3.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt3.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt3.Location = new System.Drawing.Point(237, 124);
            this.LEDSwt3.Name = "LEDSwt3";
            this.LEDSwt3.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt3.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt3.TabIndex = 2;
            this.LEDSwt3.Texts = null;
            this.LEDSwt3.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt3.TrueTextColr = System.Drawing.Color.White;
            // 
            // LED2
            // 
            this.LED2.IsHighlight = true;
            this.LED2.IsShowBorder = false;
            this.LED2.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED2.Location = new System.Drawing.Point(145, 39);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(57, 57);
            this.LED2.TabIndex = 3;
            this.LED2.TwinkleSpeed = 0;
            // 
            // LEDSwt2
            // 
            this.LEDSwt2.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt2.Checked = false;
            this.LEDSwt2.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt2.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt2.Location = new System.Drawing.Point(149, 123);
            this.LEDSwt2.Name = "LEDSwt2";
            this.LEDSwt2.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt2.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt2.TabIndex = 2;
            this.LEDSwt2.Texts = null;
            this.LEDSwt2.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt2.TrueTextColr = System.Drawing.Color.White;
            // 
            // LED1
            // 
            this.LED1.BackColor = System.Drawing.SystemColors.Control;
            this.LED1.IsHighlight = true;
            this.LED1.IsShowBorder = false;
            this.LED1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.LED1.Location = new System.Drawing.Point(57, 39);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(57, 57);
            this.LED1.TabIndex = 1;
            this.LED1.TwinkleSpeed = 0;
            // 
            // LEDSwt1
            // 
            this.LEDSwt1.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt1.Checked = false;
            this.LEDSwt1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt1.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt1.Location = new System.Drawing.Point(61, 123);
            this.LEDSwt1.Name = "LEDSwt1";
            this.LEDSwt1.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt1.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt1.TabIndex = 0;
            this.LEDSwt1.Texts = null;
            this.LEDSwt1.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt1.TrueTextColr = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::温室监控.Properties.Resources.cool_background;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ucledNums1);
            this.Controls.Add(this.Them1);
            this.Controls.Add(this.leftPanle);
            this.Name = "Form1";
            this.Text = "温室监控";
            this.leftPanle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftPanle;
        private GroupBox groupBox1;
        private HZH_Controls.Controls.UCBtnExt btn_start;
        private ComboBox cmb_serialPort;
        private Label label1;
        private HZH_Controls.Controls.UCThermometer Them1;
        private HZH_Controls.Controls.UCLEDNums ucledNums1;
        private GroupBox groupBox2;
        private HZH_Controls.Controls.UCSignalLamp LED7;
        private HZH_Controls.Controls.UCSwitch LEDSwt7;
        private HZH_Controls.Controls.UCSignalLamp LED6;
        private HZH_Controls.Controls.UCSwitch LEDSwt6;
        private HZH_Controls.Controls.UCSignalLamp LED5;
        private HZH_Controls.Controls.UCSwitch LEDSwt5;
        private HZH_Controls.Controls.UCSignalLamp LED4;
        private HZH_Controls.Controls.UCSwitch LEDSwt4;
        private HZH_Controls.Controls.UCSignalLamp LED3;
        private HZH_Controls.Controls.UCSwitch LEDSwt3;
        private HZH_Controls.Controls.UCSignalLamp LED2;
        private HZH_Controls.Controls.UCSwitch LEDSwt2;
        private HZH_Controls.Controls.UCSignalLamp LED1;
        private HZH_Controls.Controls.UCSwitch LEDSwt1;
    }
}