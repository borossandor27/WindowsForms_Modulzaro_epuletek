using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Modulzaro_epuletek
{
    abstract class Epulet 
    {
        public readonly EpuletTipus epuletTipus;
        string cim;
        int alapterulet;
        private readonly EpitesiAnyag epitesiAnyag;
        DateTime munkaKezdete;
        DateTime munkaVege;

        public string Cim { get => cim; }

        public EpitesiAnyag Epitesianyag => epitesiAnyag;

        public DateTime MunkaKezdete { get => munkaKezdete; set => munkaKezdete = value; }
        public DateTime MunkaVege { 
            get => munkaVege;
            set {
                if (value.Date < MunkaKezdete.Date)
                    throw new ArgumentException("A munkát nem lehet a kezdés előtt befejezni!");
                munkaVege = value; 
            } 
        }
        public int Alapterulet { 
            get => alapterulet; 
            set {
                if (value < 20)
                    throw new ArgumentException("Az alapterület nem lehet kevesebb 20 nm-él!");
                alapterulet = value;
            }  
        }

        public Epulet(EpuletTipus epuletTipus, string cim, int epitesianyag, DateTime munkaKezdete, DateTime munkaVege, int alapterulet)
        {
            this.cim = cim;
            this.epitesiAnyag = (EpitesiAnyag)epitesianyag;
            this.epuletTipus = epuletTipus;
            MunkaKezdete = munkaKezdete;
            MunkaVege = munkaVege;
            Alapterulet = alapterulet;
        }
        public override string ToString()
        {
            return $"{cim} ({(epuletTipus==EpuletTipus.Családiház?"cs":"tömb")})";
        }
    }
}
