using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ComPort
{
    
    public partial class Form1 : Form
    {
        int[] dataInDec;
        int dataInLength;

        string dataOut;
        string indata;
        string dataFromFile;
       
        string pathFileRX = @"E:\Diplom\RxData_from_Comport.txt";
        string pathFileTX = @"E:\Diplom\TxData.txt";

        StreamWriter RxStreamWriter;
        StreamReader TxStreamReader;
       
        public Form1()
        {
            InitializeComponent();
        }
        private string RxDataFormat(int[] dataInput)
        {
            string strOut = "";
            if (chBoxHexFormat.Checked)
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 16) ;
                }
            }
            else if (chBoxBinFormat.Checked)
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 2) ;
                }
            }
            else if (chBoxDecFormat.Checked)
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element + "\n");
                }
            }
            else if (chBoxCharFormat.Checked)
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToChar(element) ;
                }
            }
            return strOut;
        }

        private void btnUpdatePorts_Click(object sender, EventArgs e)
        /*
        * метод обновления списка обнаруженных компортов на компьютере
        */
        {
            checkBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;
            checkBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            cBoxAddToOldData.Checked = true;
            
            string[] ports = SerialPort.GetPortNames();
            cBoxPorts.Text = "";
            cBoxPorts.Items.Clear();

            if (ports.Length != 0)
            {
                cBoxPorts.Items.AddRange(ports);
                cBoxPorts.SelectedIndex = 0;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        /*
        * метод подключения к компорту и задания параметров передачи
        */
        {
            if (btnConnect.Text == "Подключиться")
            {
                try
                {
                    serialPort1.PortName = cBoxPorts.Text; //выбор порта
                    serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                    serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                    serialPort1.Open();// to open port
                    progressBar.Value = 100;
                    btnConnect.Text = "Отключиться";
                }
                catch (Exception)
                {

                    MessageBox.Show("Error of connection");
                }
            }
            else if (btnConnect.Text == "Отключиться")
            {
                serialPort1.Close();// to close port
                progressBar.Value = 0;
                btnConnect.Text = "Подключиться";
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tBoxDataOut.Text;
                serialPort1.WriteLine(dataOut);
            }
        }

        private void checkBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;
            } 
            else serialPort1.DtrEnable = false;
        }

        private void checkBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else serialPort1.RtsEnable = false;
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text  != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = tBoxDataOut.TextLength;
            int dataRXLength = tBoxReceiveData.TextLength;

            lblCountTxData.Text = Convert.ToString(dataOutLength);
            lblCountRxData.Text = Convert.ToString(dataRXLength);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            components = new Container();
            serialPort1 = new SerialPort(components);
            SuspendLayout();
        }

        private void ShowData(object sender, EventArgs e)
        {
            indata = RxDataFormat(dataInDec);

            if (cBoxAddToOldData.Checked)
            {
                tBoxReceiveData.AppendText(indata + "\n");
            }
        }
        private  void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        /*
         * метод приема данных и последующей отправки в текстовый файл, если стоит галочка на checkBox
         */
        {
            SerialPort sp = (SerialPort)sender;
            List<int> dataBuffer = new List<int>();

            while (serialPort1.BytesToRead > 0)
            {
                try
                {
                    dataBuffer.Add(serialPort1.ReadByte());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            dataInLength = dataBuffer.Count();
            dataInDec = new int [dataInLength];
            dataInDec = dataBuffer.ToArray();

            Invoke(new EventHandler(ShowData));
                
            if (chBoxSaveToTxt.Checked)
            {
                try
                {
                    RxStreamWriter = new StreamWriter(pathFileRX, true, Encoding.ASCII);
                    RxStreamWriter.WriteLine(indata);
                    RxStreamWriter.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnClearRxData_Click(object sender, EventArgs e)
        {
            if (tBoxReceiveData.Text != "")
            {
                tBoxReceiveData.Text = "";
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                TxStreamReader = new StreamReader(pathFileTX, true);
                dataFromFile = TxStreamReader.ReadLine();
                tBoxDataOut.Text = dataFromFile;
                TxStreamReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnEncypt_Click_1(object sender, EventArgs e)
        /*
        * метод для добавлении "преамбулы". Была нужна для отправки данных и stm для последующей обработки 
        */
        {
            tBoxDataOut.Text = "11" + tBoxDataOut.Text;
        }
    }
}
