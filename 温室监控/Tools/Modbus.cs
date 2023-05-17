using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 温室监控.Tools
{
    public class Modbus
    {
        private SerialPort serialPort;
        public Modbus() 
        {
           serialPort = new SerialPort();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Enabled= true;
            timer.Tick += (_, _) => 
            {
                isTimeOut = true;
                timer.Stop();
            };
        }
        private byte[] command=new byte[1024];
        public bool OpenConnet(string PortName,int BaudRate)
        {
            serialPort.PortName = PortName;
            serialPort.BaudRate = BaudRate;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            try
            {
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return serialPort.IsOpen;
        }
        public bool CloseConnet()
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            return true;
        }
        private byte[] result;//串口接收的字节数组
        private IEnumerable<string> str;//串口接收的字节数组转换为字符串的数组
        private bool ReceivedFlag = false;
        private System.Windows.Forms.Timer timer;
        private bool isTimeOut=false;


        #region 接收数据 （接收报文）
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           int size= serialPort.BytesToRead;
           result= new byte[size];
           serialPort.Read(result,0,size);
           str= result.Select(b => b.ToString("X2"));
           ReceivedFlag=true;
        }
        #endregion

        #region 发送命令 （发送报文)
        private void SendCommand(byte[] message)
        {
            if (!serialPort.IsOpen) return;
            try
            {
                serialPort.Write(message, 0, message.Length);
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }
           
        }
        //寄存器 register

        #endregion

        #region 读保持型寄存器 功能码0x03
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SalavAddr">从机地址</param>
        /// <param name="StartAddr">起始地址</param>
        /// <param name="RegisterDataPort">寄存器数</param>
        /// <returns>RegisterValue 为寄存器的值，StartAddr对应下标0</returns>
        /// 
        public async Task<int[]> readKeepRegister(byte SalavAddr, int StartAddr, int RegisterDataPort)
        {
            //byte[] message = new byte[8];
            //message[0] = SalavAddr;
            //message[1] = 0x03;
            //message[2] = (byte)((StartAddr - StartAddr % 256) / 256);//起始地址高位
            //message[3] = (byte)(StartAddr % 256);//起始地址地位
            //message[4] = (byte)((RegisterDataPort - RegisterDataPort % 256) / 256);
            //message[5] = (byte)(RegisterDataPort % 256);
            //var crc = CRC16(message);
            //message[6] = crc[0];
            //message[7] = crc[1];
            //try
            //{
            //    serialPort.Write(message, 0, message.Length);
            //}
            //catch (Exception ex)
            //{

            //}

            //  await Task.Delay(100);

            var res= FillMessage(SalavAddr, 0x03, StartAddr, RegisterDataPort);
            SendCommand(res);
            startAwaitReceived();
            var RegisterValue = BytesToRegisterArrValue(result);
            return  RegisterValue;

        }
        #endregion

        #region 读输出状态 功能码 0x01
        public async Task<IEnumerable<string>> ReadOutputStatus(byte SalavAddr, int StartAddr,int coils)
        {
            var message= FillMessage(0x01,0x01, StartAddr, coils);
            SendCommand(message);
           // await Task.Delay(100);
            return str;
        }
        #endregion

        #region 强置单线圈 写线圈 功能码0x05
        public async Task<IEnumerable<string>> WriteCoils(byte SalavAddr, int CoilsAddr, ONOFF nOFF)
        {
            var message = FillMessage(SalavAddr, 0x05, CoilsAddr, nOFF);
            SendCommand(message);

            //startAwaitReceived();
            // await Task.Delay(100);
            //timer.Start();
            //while (ReceivedFlag is false)
            //{
            //    if (isTimeOut is true)
            //    {
            //       isTimeOut = false;
            //        break;
            //    }
            //}
            //timer.Stop();
        
            return str;
        }
        #endregion
      
        #region modbus拓展方法
        public int[] BytesToRegisterArrValue(byte[] bytes)
        {
            if (bytes is null || bytes.Length < 2) return null;
            int dataLenth = (int)bytes[2];
            int[] result = new int[dataLenth/2];
            int databitStart = 3;
            int RegisterLen = 2;
            int j=0;
            for (int i = databitStart; i < dataLenth*2; i+= RegisterLen)
            {
                if (i >= bytes.Length) break;
                result[j] =bytes[i];
                result[j] <<= 8;
                result[j] |= bytes[i + 1];
                j++;
            }
            return result;
        }
        /// <summary>
        /// 填充8位数据报文
        /// </summary>
        /// <param name="SalavAddr">从机地址</param>
        /// <param name="FCode">功能码</param>
        /// <param name="StartAddr">起始地址</param>
        /// <param name="dataBit">2位数据位</param>
        /// <returns>填充好的报文</returns>
        private byte[] FillMessage(byte SalavAddr,byte FCode, int StartAddr, int dataBit)
        {
            byte[] message = new byte[8];
            message[0] = SalavAddr;
            message[1] = FCode;
            message[2] = (byte)((StartAddr - StartAddr % 256) / 256);//起始地址高位
            message[3] = (byte)(StartAddr % 256);//起始地址地位
            message[4] = (byte)((dataBit - dataBit % 256) / 256);
            message[5] = (byte)(dataBit % 256);
            var crc = CRC16(message);
            message[6] = crc[0];
            message[7] = crc[1];

            return message;
        }
        public enum ONOFF
        {
            OFF = 0,
            ON=1
        }
        private byte[] FillMessage(byte SalavAddr, byte FCode, int StartAddr, ONOFF nOFF)
        {
          
            byte[] message = new byte[8];
            message[0] = SalavAddr;
            message[1] = FCode;
            message[2] = (byte)((StartAddr - StartAddr % 256) / 256);//起始地址高位
            message[3] = (byte)(StartAddr % 256);//起始地址地位
            message[4] = nOFF is ONOFF.ON ? (byte)0xFF:(byte)0x00;
            message[5] = (byte)0x00;
            var crc = CRC16(message);
            message[6] = crc[0];
            message[7] = crc[1];

            return message;
        }

        private async void startAwaitReceived()
        {
            timer.Start();
            while (ReceivedFlag is false)
            {
                if (isTimeOut is true)
                {
                    isTimeOut = false;
                    break;
                }
            }
            timer.Stop();
            await Task.Delay(10);
        }
        #endregion

        #region CRC校验
        [DebuggerHidden]
        public byte[] CRC16(byte[] byteData)
        {
            byte[] CRC = new byte[2];
            UInt16 wCrc = 0xFFFF;
            for (int i = 0; i < byteData.Length - 2; i++)
            {
                wCrc ^= Convert.ToUInt16(byteData[i]);
                for (int j = 0; j < 8; j++)
                {
                    if ((wCrc & 0x0001) == 1)
                    {
                        wCrc >>= 1;
                        wCrc ^= 0xA001;
                    }
                    else
                    {
                        wCrc >>= 1;
                    }
                }
            }
            CRC[1] = (byte)((wCrc & 0xFF00) >> 8);
            CRC[0] = (byte)(wCrc & 0x00FF);
            return CRC;
        }
        #endregion

        ~Modbus()
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }
    }
}
