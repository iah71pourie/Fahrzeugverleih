using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    public abstract class Fahrzeug
    {
        protected string kennzeichen;
        protected string hersteller;
        protected string modell;
        protected DateTime zulassungsdatum;
        protected int anschaffungspreis;

        public Fahrzeug()
        {
            kennzeichen = "";
            hersteller = "";
            modell = "";
            zulassungsdatum = new DateTime();
            anschaffungspreis = 0;
        }

        #region Eigenschaften
        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }
        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; }
        }
        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }
        public DateTime Zulassungsdatum
        {
            get { return zulassungsdatum; }
            set { zulassungsdatum = value; }
        }
        public int Anschaffungspreis
        {
            get { return anschaffungspreis; }
            set { anschaffungspreis = value; }
        }
        public virtual double SteuerschuldBerechnen
        {
            get { return 0.0; }
        }
        #endregion        
    }
}
