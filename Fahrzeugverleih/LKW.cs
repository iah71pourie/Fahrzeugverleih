using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class LKW : Fahrzeug
    {
        private int achsenanzahl;
        private int zuladung;

        public LKW()
        {
            achsenanzahl = 0;
            zuladung = 0;
        }

        #region Eigenschaften
        public int AchsenAnzahl
        {
            get { return achsenanzahl; }
            set { achsenanzahl = value; }
        }
        public int Zuladung
        {
            get { return zuladung; }
            set { zuladung = value; }
        }
        public override int SteuerschuldBerechnen
        {
            get { return zuladung * 100; }
        }
        #endregion
    }
}
