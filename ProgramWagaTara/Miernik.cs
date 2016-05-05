using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ProgramWagaTara
{

    public interface IMiernikAdapter
    {
        void dekodujMase(string ramkaRS232);
        void ustawStabilnosc(string ramkaRS232);
        void ustawNettoBrutto(string ramkaRS232);
        void ustawZero(string ramkaRS232);
        bool czyAktywne();
        string pobierzMase();
        bool czyStabilne();
        bool czyZero();
        string nettoCzyBrutto();
        double pobierzMaseJakoLiczba();
    }

    class Rhewa : IMiernikAdapter
    {

        public bool aktywne = false;

        public string masa = "0";
        public bool stabilne = true;
        public bool zero = true;
        public string nettoBrutto = "Brutto";

        public void dekodujMase(string ramkaRS232)
        {

            string _masa = "0";

            try
            {
                string[] ramkaArray = ramkaRS232.Split(new string[] { "     &?", "     '?" }, StringSplitOptions.RemoveEmptyEntries);
                _masa = Regex.Replace(ramkaArray[0], @"[^a-zA-Z0-9 -]", "");
                _masa = Regex.Replace(_masa, @"\s+", "");
                //Console.WriteLine(_masa);

            }
            catch
            {
                Console.WriteLine("Błąd - pusta ramka");
            }

            if (_masa == "") masa = "------";
            else masa = _masa;

        }

        public void ustawStabilnosc(string ramkaRS232)
        {
            if (ramkaRS232.Contains("&"))
            {
                stabilne = true;
            }
            else if (ramkaRS232.Contains("'"))
            {
                stabilne = false;
            }
        }

        public void ustawNettoBrutto(string ramkaRS232)
        {
            string[] status = ramkaRS232.Split('?');
            char[] statusCodes = status[1].ToCharArray();
            try
            {
                if (statusCodes[3].Equals('1')) nettoBrutto = "Netto";
                else if (statusCodes[3].Equals('0')) nettoBrutto = "Brutto";
            }
            catch
            {

            }
        }

        public void ustawZero(string ramkaRS232)
        {
            string[] status = ramkaRS232.Split('?');
            char[] statusCodes = status[1].ToCharArray();
            try
            {
                if (statusCodes[2].Equals('1')) zero = true;
                else if (statusCodes[2].Equals('0')) zero = false;
            }
            catch
            {

            }
        }

        public bool czyAktywne()
        {
            return aktywne;
        }

        public bool czyStabilne()
        {
            return stabilne;
        }

        public bool czyZero()
        {
            return zero;
        }

        public string nettoCzyBrutto()
        {
            return nettoBrutto;
        }

        public string pobierzMase()
        {
            return masa;
        }

        public double pobierzMaseJakoLiczba()
        {
            string _masa = masa;
            double dMasa;

            if (Double.TryParse(_masa, out dMasa))
                return dMasa;
            else
                return 0;
        }
    }
}
