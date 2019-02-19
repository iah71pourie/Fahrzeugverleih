using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class Parkplatz
    {
        private string stellplatznummer;
        private Fahrzeug fahrzeug;
        private ParkplatzTyp parkplatzTyp;
        public Parkplatz(ParkplatzTyp parkplatzTyp)
        {
            this.parkplatzTyp = parkplatzTyp;

            switch (parkplatzTyp)
            {
                case ParkplatzTyp.PKW:
                    fahrzeug = new PKW();
                    stellplatznummer = "P";
                    break;

                case ParkplatzTyp.LKW:
                    fahrzeug = new LKW();
                    stellplatznummer = "L";
                    break;

                case ParkplatzTyp.Motorad:
                    fahrzeug = new Motorrad();
                    stellplatznummer = "M";
                    break;
            }
        }

        #region Eigenschaften
        public ParkplatzTyp ParkplatzTyp
        {
            get { return parkplatzTyp; }
            set { parkplatzTyp = value; }
        }
        public string Stellplatznummer
        {
            get { return stellplatznummer; }
            set { stellplatznummer = value; }
        }
        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
            set { fahrzeug = value; }
        }
        #endregion
    }

    public enum ParkplatzTyp
    {
        PKW,
        LKW,
        Motorad
    }
}