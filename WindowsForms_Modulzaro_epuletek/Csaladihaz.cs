using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Modulzaro_epuletek
{
    internal class Csaladihaz : Epulet, Kiegeszites
    {
        int ottelok;
        bool vanGarazs;
        TetoTipusa tetoTipusa;

        public int Ottelok { get => ottelok; set => ottelok = value; }
        public bool VanGarazs { get => vanGarazs; set => vanGarazs = value; }
        public TetoTipusa TetoTipusa { get => tetoTipusa; set => tetoTipusa = value; }

        public Csaladihaz(EpuletTipus epuletTipus, string cim, int epitesianyag, DateTime munkaKezdete, DateTime munkaVege, int alapterulet, int ottelok, bool vanGarazs, int tetoTipusa):base(epuletTipus, cim, epitesianyag, munkaKezdete, munkaVege, alapterulet)
        {
            Ottelok = ottelok;
            VanGarazs = vanGarazs;
            TetoTipusa = (TetoTipusa)tetoTipusa;
        }

        public void arBecsles()
        {
            throw new NotImplementedException();
        }

        public void toCSV()
        {
            throw new NotImplementedException();
        }
    }
}
