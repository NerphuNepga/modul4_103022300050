using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300050
{
    internal class KodeProduk
    {
        public string getKodeProduk(string produkElectronic)
        {
            string[] produkElec = {"Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"};
            string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};

            string kodProduk = "";
            int i = 0;
            while (i <= produkElec.Length) { 
                if (produkElectronic == produkElec[i])
                {
                    return kodeProduk[i];
                }
                i++;
            }

            return kodProduk;
        }
    }
}
