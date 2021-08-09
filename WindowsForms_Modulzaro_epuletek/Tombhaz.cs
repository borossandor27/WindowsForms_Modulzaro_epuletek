using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Modulzaro_epuletek
{
    class Tombhaz :Epulet,Kiegeszites
    {
        readonly int lakasokSzama;
        LakasfenntartasTipus lakasfenntartasTipus;
        readonly bool vanLift;

        public int LakasokSzama => lakasokSzama;

        internal LakasfenntartasTipus LakasfenntartasTipus { get => lakasfenntartasTipus; set => lakasfenntartasTipus = value; }

        public bool VanLift => vanLift;

        public Tombhaz(EpuletTipus epuletTipus, string cim, int epitesianyag, DateTime munkaKezdete, DateTime munkaVege, int alapterulet, int lakasokSzama, bool vanLift, int lakasfenntartasTipus) : base(epuletTipus, cim, epitesianyag, munkaKezdete, munkaVege, alapterulet)
        {
            this.lakasokSzama = lakasokSzama;
            this.vanLift = vanLift;
            LakasfenntartasTipus = (LakasfenntartasTipus)lakasfenntartasTipus;
        }

        public void toCSV()
        {
            throw new NotImplementedException();
        }

        public void arBecsles()
        {
            throw new NotImplementedException();
        }
    }
}
