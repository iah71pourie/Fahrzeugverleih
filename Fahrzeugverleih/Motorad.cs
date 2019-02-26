using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class Motorad : Fahrzeug
    {
        private int hubraum;

        public Motorad() { }

        #region Eigenschaften
        public int Hubraum
        {
            get { return hubraum; }
            set { hubraum = value; }
        }
        public override int SteuerschuldBerechnen
        {
            get { return (hubraum + 99) / 100 * 20; }
        }
        #endregion
    }
}
