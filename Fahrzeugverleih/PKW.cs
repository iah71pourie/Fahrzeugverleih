using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class PKW : Fahrzeug
    {
        private int hubraum;
        private int leistung;
        private int schadstoffklasse;

        public PKW()
        {
            hubraum = 0;
            leistung = 0;
            schadstoffklasse = 0;
        }

        #region Eigenschaften
        public int Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
        }
        public int Leistung
        {
            get { return leistung; }
            set { leistung = value; }
        }
        public int Schadstoffklasse
        {
            get { return schadstoffklasse; }
            set { schadstoffklasse = value; }
        }
        public override int SteuerschuldBerechnen
        {
            get { return ((hubraum + 99) / 100) * 10 * (schadstoffklasse + 1); }
        }
        #endregion
    }
}
