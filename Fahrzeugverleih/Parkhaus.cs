using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    public class Parkhaus
    {
        private string ort;
        private int plz;
        private string straße;
        private List<Parkplatz> parkplätze;

        public Parkhaus()
        {
            parkplätze = new List<Parkplatz>();
        }

        #region Eigenschaften
        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }
        public int PLZ
        {
            get { return plz; }
            set { plz = value; }
        }
        public string Straße
        {
            get { return straße; }
            set { straße = value; }
        }
        public List<Parkplatz> Parkplätze
        {
            get { return parkplätze; }
            set { parkplätze = value; }
        }
        #endregion
    }
}
