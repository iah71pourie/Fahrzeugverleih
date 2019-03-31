using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    public class Parkplatz
    {
        private string stellplatznummer;
        private string kennzeichen;
        private ParkplatzTyp parkplatzTyp;

        public Parkplatz(ParkplatzTyp parkplatzTyp)
        {
            this.parkplatzTyp = parkplatzTyp;
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
        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }
        #endregion
    }

    public enum ParkplatzTyp
    {
        PKW,
        LKW,
        Motorrad
    }
}