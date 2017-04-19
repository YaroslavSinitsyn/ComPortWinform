using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlcTestApp
{
    public partial class MainForm : Form
    {
        //03 .
        string endHex = "03";
         
        //02 57 48 4F 53 5F 54 48 45 52 45 03 .WHOS_THERE.
        string initHexCommand = "0257484F535F544845524503";

        //02 4C 41 42 45 4C 5F 46 45 45 44 23 39 30 30 30 03    .LABEL_FEED#9000.
        string hexCommandSetSpeed = "024C4142454C5F4645454423";

        //02 4C 41 42 45 4C 5F 4C 45 4E 47 54 48 23 30 31 30 30 03   .LABEL_LENGTH#0100.
        string hexCommandSetLength = "024C4142454C5F4C454E47544823";

        //02 52 53 54 41 52 54 5F 47 52 03                  .RSTART_GR.
        string hexCommandSetGood = "025253544152545F475203";

        //02 52 53 54 41 52 54 5F 4E 52 03                  .RSTART_NR.
        string hexCommandSetBad = "025253544152545F4E5203";

        // 02 20 52 53 49 5F 39 38 38 31 33 5F 34 5F 30 30 30 32 0D 0A 03   . RSI_98813_4_0002...
        string hexResponCommandOnStart = "02205253495F39383831335F345F303030320D0A03";

        //02 20 52 53 49 5F 41 43 4B 5F 30 30 30 32 0D 0A 03   . RSI_ACK_0002...
        string hexResponCommandACK = "02205253495F41434B5F303030320D0A03";

        public MainForm()
        {
           InitializeComponent();
        }

        public string AsciiToHex(string strNumber)
        {
            char[] charValues = strNumber.ToCharArray();
            string hexOutput = "";

            foreach (char _eachChar in charValues)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(_eachChar);
                // Convert the decimal value to a hexadecimal value in string form.
                hexOutput += String.Format("{0:X}", value);
                // to make output as your eg 
                //  hexOutput +=" "+ String.Format("{0:X}", value);
            }

            if (hexOutput.Length < 8)
            {
                int count = (8 - hexOutput.Length) / 2;
                switch (count)
                {
                    case 1:
                        hexOutput = "30" + hexOutput;
                        break;
                    case 2:
                        hexOutput = "3030" + hexOutput;
                        break;
                    case 3:
                        hexOutput = "303030" + hexOutput;
                        break;
                }
            }

            return hexOutput;
        }

        public static string CheckHex(string input)
        {
            string result = input;
            if (input.Length % 2 != 0)
                result = '0' + result;
            return result;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public void TextHexData(TextBox textBox, byte[] byteArray)
        {
            if (textBox.Text != string.Empty)
                textBox.Text += System.Environment.NewLine;

            string strAscii = Encoding.ASCII.GetString(byteArray);
            string strHex = BitConverter.ToString(byteArray);
            DateTime dateNow = DateTime.Now;
            string strDate = dateNow.ToString("yyyy-MM-dd hh:mm:ss.fff");

            textBox.Text += strHex + "   " + strAscii + "     " + strDate;
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            byte[] byteArray = StringToByteArray(initHexCommand);

            TextHexData(txtBoxWrite, byteArray);

            SendCommand(byteArray);
        }

        private void SendCommand(byte[] byteArray)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
                
                serialPort1.Write(byteArray, 0, byteArray.Length);

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
            finally
            {
                //serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);

            //SerialPort sp = (SerialPort)sender;

            //byte[] byteArrayData = new byte[sp.BytesToRead];
            //sp.Read(byteArrayData, 0, byteArrayData.Length);

            //TextHexData(txtBoxRead, byteArrayData);

            this.Invoke(new EventHandler(DoUpdate));
        }

        private void DoUpdate(object s, EventArgs e)
        {
            txtBoxRead.Text = serialPort1.ReadExisting();
        }


        private void btnSpeed_Click(object sender, EventArgs e)
        {
            string asciiNumber = AsciiToHex(txtSpeed.Text);
            string sendCommand = hexCommandSetSpeed + asciiNumber + endHex;

            byte[] byteArray = StringToByteArray(sendCommand);

            TextHexData(txtBoxWrite, byteArray);

            SendCommand(byteArray);
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string asciiNumber = AsciiToHex(txtBoxLength.Text);
            string sendCommand = hexCommandSetLength + asciiNumber + endHex;

            byte[] byteArray = StringToByteArray(sendCommand);

            TextHexData(txtBoxWrite, byteArray);

            SendCommand(byteArray);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string asciiNumber = AsciiToHex(txtBoxStop.Text);

            string sendCommand = hexCommandSetLength + asciiNumber + endHex;

            byte[] byteArray = StringToByteArray(sendCommand);

            TextHexData(txtBoxWrite, byteArray);

            SendCommand(byteArray);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            byte[] byteArray = StringToByteArray(hexCommandSetGood);

            TextHexData(txtBoxWrite, byteArray);

            SendCommand(byteArray);
        }

        private void btnBead_Click(object sender, EventArgs e)
        {
            byte[] byteArray = StringToByteArray(hexCommandSetBad);

            TextHexData(txtBoxWrite, byteArray);

            SendCommand(byteArray);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            
            byte[] byteArray = StringToByteArray(hexResponCommandOnStart);

            TextHexData(txtBoxRead, byteArray);
        }

        private void btnAck_Click(object sender, EventArgs e)
        {
            byte[] byteArray = StringToByteArray(hexResponCommandACK);

            TextHexData(txtBoxRead, byteArray);
        }

        private void btnAuto_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();
        }

        private void btnApplay_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = txtPortName.Text;
            serialPort1.BaudRate = Convert.ToInt32(txtPortSpeed.Text);
            serialPort1.Open();
        }
    }
}
