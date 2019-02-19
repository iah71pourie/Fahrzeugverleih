using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class Motorrad : Fahrzeug
    {
        private int hubraum;

        public Motorrad()
        {
            hubraum = 0;
        }

        #region Eigenschaften
        public int Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
        }
        public override double SteuerschuldBerechnen
        {
            get { return (hubraum + 99) / 100 * 20; }
        }
        #endregion
    }
}
