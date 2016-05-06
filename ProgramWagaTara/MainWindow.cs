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
using System.Timers;

namespace ProgramWagaTara
{
    public partial class MainWindow : Form
    {
        IMiernikAdapter miernik;
        Interfejs interfejs;

        private BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        bool[] aktywnosc;

        SerialPort serialPort;
        public MainWindow()
        {
            InitializeComponent();

            string portName = Properties.Settings.Default.PortCom;

            this.FillCOMPorts();
            this.COMPortsComboBox.Text = (string.IsNullOrWhiteSpace(portName)) ? "COM1" : portName;

            serialPort = new SerialPort();
            serialPort.PortName = (string.IsNullOrWhiteSpace(portName)) ? "COM1" : portName;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.BaudRate = 9600;

            miernik = new Rhewa();
            interfejs = new RS232(miernik, serialPort);
            serialPort = (SerialPort)interfejs.pobierajZWagi();
            interfejs.DataReceived += InterfaceDataReceived;

            aktywnosc = new bool[5];

            this.backgroundWorker1.RunWorkerAsync();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 100;
            aTimer.Enabled = true;
            
        }

        public void InterfaceDataReceived(object sender, EventArgs e)
        {
            this.setActiveStatus(true);
            this.setDataLabel(miernik.pobierzMase());
            this.setStabilityLabel(miernik.czyStabilne());
            this.setZeroLabel(miernik.czyZero());
            this.setGossNetLabel(miernik.nettoCzyBrutto());
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.setActiveStatus(false);
            bool allEqual = aktywnosc.All(s => bool.Equals(false, s));
            if (allEqual)
            {
                this.Masa.BeginInvoke((MethodInvoker)delegate()
                {
                    this.Masa.Text = "-----";
                });
                this.Masa.BackColor = Color.Salmon;
                this.Jednostka.BackColor = Color.Salmon;
                this.Netto.BackColor = Color.Salmon;
                this.NettoCheckbox.BackColor = Color.Salmon;
                this.Brutto.BackColor = Color.Salmon;
                this.BruttoCheckbox.BackColor = Color.Salmon;
                this.stabilne.BackColor = Color.Salmon;
                this.zero.BackColor = Color.Salmon;
            }
        }

        private void setActiveStatus(bool status)
        {
            for (int x = 1; x < aktywnosc.Length; x++)
            {
                aktywnosc[x-1] = aktywnosc[x];
            }
            aktywnosc[aktywnosc.Length - 1] = status;
        }

        private void setDataLabel(string data)
        {
            if (this.Masa.InvokeRequired)
            {
                this.Masa.BeginInvoke((MethodInvoker)delegate() {
                    this.Masa.Text = data; 
                });
            }
            this.Masa.BackColor = Color.LimeGreen;
            this.Jednostka.BackColor = Color.LimeGreen;
            this.Netto.BackColor = Color.LimeGreen;
            this.Brutto.BackColor = Color.LimeGreen;
        }

        private void setStabilityLabel(bool stable)
        {
            if (stable) this.stabilne.BackColor = Color.Chartreuse;
            else this.stabilne.BackColor = Color.Salmon;
        }

        private void setZeroLabel(bool zero)
        {
            if (zero) this.zero.BackColor = Color.Chartreuse;
            else this.zero.BackColor = Color.Salmon;
        }

        private void setGossNetLabel(string grossNet)
        {
            if (grossNet.Equals("Brutto"))
            { 
                this.BruttoCheckbox.BackColor = Color.Chartreuse;
                this.NettoCheckbox.BackColor = Color.LimeGreen;
                if (this.Masa.InvokeRequired)
                {
                    this.Masa.BeginInvoke((MethodInvoker)delegate()
                    {
                        this.UsunTareButton.Enabled = false;
                    });
                }
            }
            else if(grossNet.Equals("Netto"))
            {
                this.BruttoCheckbox.BackColor = Color.LimeGreen;
                this.NettoCheckbox.BackColor = Color.Chartreuse;
                if (this.Masa.InvokeRequired)
                {
                    this.Masa.BeginInvoke((MethodInvoker)delegate()
                    {
                        this.UsunTareButton.Enabled = true;
                    });
                }
            }
        }

        private void FillCOMPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            this.COMPortsComboBox.Items.AddRange(ports);
        }

        private void COMPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PortCom = this.COMPortsComboBox.Text;
            Properties.Settings.Default.Save();
        }

        private void taraTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.taraTextBox.Text)) this.TarujButton.Enabled = false;
            else this.TarujButton.Enabled = true;
        }

        private void TarujButton_Click(object sender, EventArgs e)
        {
            byte[] clearResponse = System.Text.Encoding.UTF8.GetBytes("<FT>");
            serialPort.Write(clearResponse, 0, clearResponse.Length);
        }

        private void UsunTareButton_Click(object sender, EventArgs e)
        {
            byte[] clearResponse = System.Text.Encoding.UTF8.GetBytes("<Ft>");
            serialPort.Write(clearResponse, 0, clearResponse.Length);
            this.ActiveControl = this.TarujButton;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
