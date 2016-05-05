using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ProgramWagaTara
{
    public interface Interfejs
    {
        event EventHandler DataReceived;

        object pobierajZWagi();

    }

    class RS232 : Interfejs
    {
        public event EventHandler DataReceived;

        SerialPort serialPort;
        IMiernikAdapter miernik;
        string ramka;

        public RS232(IMiernikAdapter _miernik, SerialPort port)
        {
            miernik = _miernik;
            serialPort = port;
        }

        public object pobierajZWagi()
        {

            if (serialPort is SerialPort && !serialPort.IsOpen)
            {

                try
                {
                    

                    serialPort.Open();
                    serialPort.DiscardOutBuffer();
                    serialPort.DiscardInBuffer();
                    
                    byte[] clearResponse = System.Text.Encoding.UTF8.GetBytes("<H0>");
                    serialPort.Write(clearResponse, 0, clearResponse.Length);

                    serialPort.DataReceived += new SerialDataReceivedEventHandler(responseHandler);

                }
                catch (Exception message)
                {
                    Console.WriteLine(message.ToString());
                }

            }

            return serialPort;
        }

        public void responseHandler(object sender, SerialDataReceivedEventArgs args)
        {
            if (serialPort != null)
            {
                ramka = serialPort.ReadLine();
                miernik.ustawNettoBrutto(ramka);
                miernik.ustawStabilnosc(ramka);
                miernik.ustawZero(ramka);
                miernik.dekodujMase(ramka);

                DataReceived(this, null);
                //Console.WriteLine(miernik.czyStabilne().ToString());
            }
        }
    }

}
