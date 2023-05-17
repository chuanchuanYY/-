using HZH_Controls.Controls;
using System.Diagnostics;
using System.IO.Ports;
using 温室监控.Controls;
using 温室监控.Tools;
using Timer = System.Windows.Forms.Timer;

namespace 温室监控
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Modbus modbus;
        private Timer timer;
        private int Them1Value;
        private List<mLED> mLEDs= new List<mLED>();
        private event EventHandler OnReceiveValueChaned;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.leftPanle.BackColor = Color.FromArgb(80, 224, 231, 236);
            cmb_serialPort.DataSource = SerialPort.GetPortNames();
            initModbus();
            OnReceiveValueChaned += Form1_OnReceiveValueChaned;
            initP2LED();
        }

        private void initModbus()
        {
            modbus = new Modbus();
            timer = new Timer();
            timer.Enabled = false;
            timer.Tick += async (_, _) =>
            {
                this.Invoke(new Action(async () => {
                    var registerValues = await modbus.readKeepRegister(01, 0000, 0001);
                    try
                    {
                        if (registerValues is not null && registerValues?.Length >= 1)
                        {
                            Them1Value = registerValues[0];
                            Form1_OnReceiveValueChaned(this, new());
                        }
                    }
                    catch (Exception)
                    {

                    }
                }));

            };
        }

        private void initP2LED()
        {
            LEDSwt1.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt2.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt3.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt4.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt5.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt6.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt7.CheckedChanged += LEDSwt1_CheckedChanged;
            LEDSwt8.CheckedChanged += LEDSwt1_CheckedChanged;
            Fanswt1.CheckedChanged +=async (_,_)=> 
            {
                Fanswt1.Enabled= false;
                await modbus.WriteCoils(0x01, 0008, Fanswt1.Checked ? Modbus.ONOFF.ON : Modbus.ONOFF.OFF);
                if (Fanswt1.Checked)
                {
                    ucRotor1.RotorAround = RotorAround.Clockwise;
                }
                else ucRotor1.RotorAround = RotorAround.None;
                Fanswt1.Enabled = true;
            };

            for (int i = LEDpanle.Controls.Count-1; i >=0; i--)
            {
                mLEDs.Add((mLED)LEDpanle.Controls[i]);
            }
        }

        private async void LEDSwt1_CheckedChanged(object? sender, EventArgs e)
        {
            var swt = sender as UCSwitch;
            swt!.Enabled = false;
            var colisAddr= SwitchNumber(swt!.Name);
            await  modbus.WriteCoils(0x01, colisAddr,swt.Checked?Modbus.ONOFF.ON:Modbus.ONOFF.OFF);
            if (swt.Checked)
            {
                mLEDs[colisAddr].LedColor = Color.FromArgb(255, 255, 77, 59);
            }
            else
            {
                mLEDs[colisAddr].LedColor = Color.FromArgb(255, 224, 224, 224);
            }
            swt.Enabled = true;
            
        }

        private int SwitchNumber(string name) =>
            name switch
            {
                "LEDSwt1" => 0000,
                "LEDSwt2" => 0001,
                "LEDSwt3" => 0002,
                "LEDSwt4" => 0003,
                "LEDSwt5" => 0004,
                "LEDSwt6" => 0005,
                "LEDSwt7" => 0006,
                "LEDSwt8"=>0007,
                _ => throw new NotImplementedException()
            };
        private void Form1_OnReceiveValueChaned(object? sender, EventArgs e)
        {
            Them1.Value = Them1Value;
            ucledNums1.Value= Them1Value.ToString();
        }

        private void btn_start_BtnClick(object sender, EventArgs e)
        {
            if (btn_start.BtnText.Trim().Equals("启动"))
            {
                var port = cmb_serialPort.SelectedValue.ToString();
                modbus.OpenConnet(port!, 4800);
                btn_start.BtnText = "关闭";
                btn_start.FillColor=Color.FromArgb(255,255,77,59);

                timer.Interval = 1000;
                timer.Start();
            }
            else if (btn_start.BtnText.Trim().Equals("关闭"))
            {
                btn_start.BtnText = "启动";
                btn_start.FillColor = Color.FromArgb(255, 15, 35, 93);
                timer.Stop();
                modbus.CloseConnet();
            }
        }
    }
}