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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start = new HZH_Controls.Controls.UCBtnExt();
            this.cmb_serialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Them1 = new HZH_Controls.Controls.UCThermometer();
            this.ucledNums1 = new HZH_Controls.Controls.UCLEDNums();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LEDSwtPanle = new System.Windows.Forms.Panel();
            this.LEDSwt8 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt7 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt6 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt5 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt4 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt3 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt2 = new HZH_Controls.Controls.UCSwitch();
            this.LEDSwt1 = new HZH_Controls.Controls.UCSwitch();
            this.LEDpanle = new System.Windows.Forms.Panel();
            this.mled7 = new 温室监控.Controls.mLED();
            this.mled6 = new 温室监控.Controls.mLED();
            this.mled5 = new 温室监控.Controls.mLED();
            this.mled4 = new 温室监控.Controls.mLED();
            this.mled3 = new 温室监控.Controls.mLED();
            this.mled2 = new 温室监控.Controls.mLED();
            this.mled1 = new 温室监控.Controls.mLED();
            this.LED1 = new 温室监控.Controls.mLED();
            this.Fanswt1 = new HZH_Controls.Controls.UCSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.ucWave1 = new HZH_Controls.Controls.UCWave();
            this.ucRotor1 = new HZH_Controls.Controls.UCRotor();
            this.label3 = new System.Windows.Forms.Label();
            this.leftPanle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.LEDSwtPanle.SuspendLayout();
            this.LEDpanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanle
            // 
            this.leftPanle.BackColor = System.Drawing.Color.White;
            this.leftPanle.Controls.Add(this.label5);
            this.leftPanle.Controls.Add(this.label4);
            this.leftPanle.Controls.Add(this.groupBox1);
            this.leftPanle.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanle.Location = new System.Drawing.Point(0, 0);
            this.leftPanle.Name = "leftPanle";
            this.leftPanle.Size = new System.Drawing.Size(260, 673);
            this.leftPanle.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
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
            this.Them1.Location = new System.Drawing.Point(340, 12);
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
            this.ucledNums1.Location = new System.Drawing.Point(435, 339);
            this.ucledNums1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucledNums1.Name = "ucledNums1";
            this.ucledNums1.Size = new System.Drawing.Size(94, 65);
            this.ucledNums1.TabIndex = 2;
            this.ucledNums1.Value = "66.66";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LEDSwtPanle);
            this.groupBox2.Controls.Add(this.LEDpanle);
            this.groupBox2.Location = new System.Drawing.Point(513, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P2LED";
            // 
            // LEDSwtPanle
            // 
            this.LEDSwtPanle.Controls.Add(this.LEDSwt8);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt7);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt6);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt5);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt4);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt3);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt2);
            this.LEDSwtPanle.Controls.Add(this.LEDSwt1);
            this.LEDSwtPanle.Location = new System.Drawing.Point(48, 118);
            this.LEDSwtPanle.Name = "LEDSwtPanle";
            this.LEDSwtPanle.Size = new System.Drawing.Size(683, 48);
            this.LEDSwtPanle.TabIndex = 8;
            // 
            // LEDSwt8
            // 
            this.LEDSwt8.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt8.Checked = false;
            this.LEDSwt8.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt8.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt8.Location = new System.Drawing.Point(614, 11);
            this.LEDSwt8.Name = "LEDSwt8";
            this.LEDSwt8.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt8.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt8.TabIndex = 4;
            this.LEDSwt8.Texts = null;
            this.LEDSwt8.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt8.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt7
            // 
            this.LEDSwt7.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt7.Checked = false;
            this.LEDSwt7.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt7.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt7.Location = new System.Drawing.Point(543, 11);
            this.LEDSwt7.Name = "LEDSwt7";
            this.LEDSwt7.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt7.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt7.TabIndex = 5;
            this.LEDSwt7.Texts = null;
            this.LEDSwt7.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt7.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt6
            // 
            this.LEDSwt6.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt6.Checked = false;
            this.LEDSwt6.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt6.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt6.Location = new System.Drawing.Point(455, 11);
            this.LEDSwt6.Name = "LEDSwt6";
            this.LEDSwt6.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt6.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt6.TabIndex = 6;
            this.LEDSwt6.Texts = null;
            this.LEDSwt6.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt6.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt5
            // 
            this.LEDSwt5.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt5.Checked = false;
            this.LEDSwt5.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt5.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt5.Location = new System.Drawing.Point(367, 11);
            this.LEDSwt5.Name = "LEDSwt5";
            this.LEDSwt5.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt5.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt5.TabIndex = 7;
            this.LEDSwt5.Texts = null;
            this.LEDSwt5.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt5.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt4
            // 
            this.LEDSwt4.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt4.Checked = false;
            this.LEDSwt4.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt4.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt4.Location = new System.Drawing.Point(279, 11);
            this.LEDSwt4.Name = "LEDSwt4";
            this.LEDSwt4.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt4.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt4.TabIndex = 8;
            this.LEDSwt4.Texts = null;
            this.LEDSwt4.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt4.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt3
            // 
            this.LEDSwt3.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt3.Checked = false;
            this.LEDSwt3.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt3.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt3.Location = new System.Drawing.Point(191, 12);
            this.LEDSwt3.Name = "LEDSwt3";
            this.LEDSwt3.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt3.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt3.TabIndex = 9;
            this.LEDSwt3.Texts = null;
            this.LEDSwt3.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt3.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt2
            // 
            this.LEDSwt2.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt2.Checked = false;
            this.LEDSwt2.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt2.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt2.Location = new System.Drawing.Point(103, 11);
            this.LEDSwt2.Name = "LEDSwt2";
            this.LEDSwt2.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt2.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt2.TabIndex = 10;
            this.LEDSwt2.Texts = null;
            this.LEDSwt2.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt2.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDSwt1
            // 
            this.LEDSwt1.BackColor = System.Drawing.Color.Transparent;
            this.LEDSwt1.Checked = false;
            this.LEDSwt1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.LEDSwt1.FalseTextColr = System.Drawing.Color.White;
            this.LEDSwt1.Location = new System.Drawing.Point(15, 11);
            this.LEDSwt1.Name = "LEDSwt1";
            this.LEDSwt1.Size = new System.Drawing.Size(53, 25);
            this.LEDSwt1.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.LEDSwt1.TabIndex = 3;
            this.LEDSwt1.Texts = null;
            this.LEDSwt1.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.LEDSwt1.TrueTextColr = System.Drawing.Color.White;
            // 
            // LEDpanle
            // 
            this.LEDpanle.Controls.Add(this.mled7);
            this.LEDpanle.Controls.Add(this.mled6);
            this.LEDpanle.Controls.Add(this.mled5);
            this.LEDpanle.Controls.Add(this.mled4);
            this.LEDpanle.Controls.Add(this.mled3);
            this.LEDpanle.Controls.Add(this.mled2);
            this.LEDpanle.Controls.Add(this.mled1);
            this.LEDpanle.Controls.Add(this.LED1);
            this.LEDpanle.Location = new System.Drawing.Point(48, 26);
            this.LEDpanle.Name = "LEDpanle";
            this.LEDpanle.Size = new System.Drawing.Size(683, 92);
            this.LEDpanle.TabIndex = 3;
            // 
            // mled7
            // 
            this.mled7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled7.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled7.Location = new System.Drawing.Point(612, 18);
            this.mled7.Name = "mled7";
            this.mled7.Size = new System.Drawing.Size(57, 57);
            this.mled7.TabIndex = 5;
            // 
            // mled6
            // 
            this.mled6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled6.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled6.Location = new System.Drawing.Point(539, 18);
            this.mled6.Name = "mled6";
            this.mled6.Size = new System.Drawing.Size(57, 57);
            this.mled6.TabIndex = 5;
            // 
            // mled5
            // 
            this.mled5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled5.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled5.Location = new System.Drawing.Point(451, 18);
            this.mled5.Name = "mled5";
            this.mled5.Size = new System.Drawing.Size(57, 57);
            this.mled5.TabIndex = 6;
            // 
            // mled4
            // 
            this.mled4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled4.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled4.Location = new System.Drawing.Point(363, 18);
            this.mled4.Name = "mled4";
            this.mled4.Size = new System.Drawing.Size(57, 57);
            this.mled4.TabIndex = 7;
            // 
            // mled3
            // 
            this.mled3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled3.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled3.Location = new System.Drawing.Point(275, 18);
            this.mled3.Name = "mled3";
            this.mled3.Size = new System.Drawing.Size(57, 57);
            this.mled3.TabIndex = 8;
            // 
            // mled2
            // 
            this.mled2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled2.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled2.Location = new System.Drawing.Point(187, 18);
            this.mled2.Name = "mled2";
            this.mled2.Size = new System.Drawing.Size(57, 57);
            this.mled2.TabIndex = 9;
            // 
            // mled1
            // 
            this.mled1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mled1.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mled1.Location = new System.Drawing.Point(99, 18);
            this.mled1.Name = "mled1";
            this.mled1.Size = new System.Drawing.Size(57, 57);
            this.mled1.TabIndex = 10;
            // 
            // LED1
            // 
            this.LED1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED1.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LED1.Location = new System.Drawing.Point(11, 18);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(57, 57);
            this.LED1.TabIndex = 11;
            // 
            // Fanswt1
            // 
            this.Fanswt1.BackColor = System.Drawing.Color.Transparent;
            this.Fanswt1.Checked = false;
            this.Fanswt1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.Fanswt1.FalseTextColr = System.Drawing.Color.White;
            this.Fanswt1.Location = new System.Drawing.Point(1128, 299);
            this.Fanswt1.Name = "Fanswt1";
            this.Fanswt1.Size = new System.Drawing.Size(53, 25);
            this.Fanswt1.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.Fanswt1.TabIndex = 2;
            this.Fanswt1.Texts = null;
            this.Fanswt1.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.Fanswt1.TrueTextColr = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 140);
            this.label2.TabIndex = 4;
            this.label2.Text = "环\r\n境\r\n温\r\n度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucWave1
            // 
            this.ucWave1.Location = new System.Drawing.Point(266, 635);
            this.ucWave1.Name = "ucWave1";
            this.ucWave1.Size = new System.Drawing.Size(995, 38);
            this.ucWave1.TabIndex = 5;
            this.ucWave1.Text = "ucWave1";
            this.ucWave1.WaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWave1.WaveHeight = 30;
            this.ucWave1.WaveSleep = 50;
            this.ucWave1.WaveWidth = 200;
            // 
            // ucRotor1
            // 
            this.ucRotor1.Location = new System.Drawing.Point(1053, 192);
            this.ucRotor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucRotor1.Name = "ucRotor1";
            this.ucRotor1.RotorAround = HZH_Controls.Controls.RotorAround.None;
            this.ucRotor1.RotorColor = System.Drawing.Color.Black;
            this.ucRotor1.Size = new System.Drawing.Size(197, 99);
            this.ucRotor1.Speed = 100;
            this.ucRotor1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1038, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "风扇开关：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::温室监控.Properties.Resources.cool_background;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucRotor1);
            this.Controls.Add(this.ucWave1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fanswt1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ucledNums1);
            this.Controls.Add(this.Them1);
            this.Controls.Add(this.leftPanle);
            this.Name = "Form1";
            this.Text = "温室监控";
            this.leftPanle.ResumeLayout(false);
            this.leftPanle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.LEDSwtPanle.ResumeLayout(false);
            this.LEDpanle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel LEDpanle;
        private Controls.mLED mled6;
        private Controls.mLED mled5;
        private Controls.mLED mled4;
        private Controls.mLED mled3;
        private Controls.mLED mled2;
        private Controls.mLED mled1;
        private Controls.mLED LED1;
        private Controls.mLED mled7;
        private HZH_Controls.Controls.UCSwitch Fanswt1;
        private Label label2;
        private HZH_Controls.Controls.UCWave ucWave1;
        private HZH_Controls.Controls.UCRotor ucRotor1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Panel LEDSwtPanle;
        private HZH_Controls.Controls.UCSwitch LEDSwt8;
        private HZH_Controls.Controls.UCSwitch LEDSwt7;
        private HZH_Controls.Controls.UCSwitch LEDSwt6;
        private HZH_Controls.Controls.UCSwitch LEDSwt5;
        private HZH_Controls.Controls.UCSwitch LEDSwt4;
        private HZH_Controls.Controls.UCSwitch LEDSwt3;
        private HZH_Controls.Controls.UCSwitch LEDSwt2;
        private HZH_Controls.Controls.UCSwitch LEDSwt1;
    }
}