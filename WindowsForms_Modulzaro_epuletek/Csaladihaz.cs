using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Modulzaro_epuletek
{
    internal class Csaladihaz : Epulet, Arbecsles, CSV
    {
        int ottelok;
        bool vanGarazs;
        TetoTipusa tetoTipusa;
        private object v1;
        private string v2;
        private object v3;
        private DateTime dateTime1;
        private DateTime dateTime2;
        private int v4;
        private int v5;
        private bool v6;
        private object v7;

        public int Ottelok { get => ottelok; set => ottelok = value; }
        public bool VanGarazs { get => vanGarazs; set => vanGarazs = value; }
        public TetoTipusa TetoTipusa { get => tetoTipusa; set => tetoTipusa = value; }

        public Csaladihaz(EpuletTipus epuletTipus, string cim, int epitesianyag, DateTime munkaKezdete, DateTime munkaVege, int alapterulet, int ottelok, bool vanGarazs, TetoTipusa tetoTipusa):base(epuletTipus, cim, epitesianyag, munkaKezdete, munkaVege, alapterulet)
        {
            Ottelok = ottelok;
            VanGarazs = vanGarazs;
            TetoTipusa = (TetoTipusa)tetoTipusa;
        }

 
        public string toCSV()
        {
            return string.Join(";", base.epuletTipus, base.Cim, base.Alapterulet, base.Epitesianyag, base.MunkaKezdete.ToString("yyyy-MM-dd"), base.MunkaVege.ToString("yyyy-MM-dd"),Alapterulet, ottelok, VanGarazs.ToString(),tetoTipusa.ToString());
        }

        public double arBecsles()
        {
            return Alapterulet * ottelok * 10000;
        }
    }
}
