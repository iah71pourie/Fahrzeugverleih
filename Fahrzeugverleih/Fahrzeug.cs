using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    public abstract class Fahrzeug
    {
        protected string hersteller;
        protected string modell;
        protected string kennzeichen;
        protected DateTime zulassungsjahr;
        protected int anschaffungspreis;

        public Fahrzeug()
        {
            hersteller = "";
            modell = "";
            kennzeichen = "";
            zulassungsjahr = new DateTime();
            anschaffungspreis = 0;
        }

        #region Eigenschaften
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
        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }
        public DateTime Zulassungsjahr
        {
            get { return zulassungsjahr; }
            set { zulassungsjahr = value; }
        }
        public int Anschaffungspreis
        {
            get { return anschaffungspreis; }
            set { anschaffungspreis = value; }
        }
        public virtual int SteuerschuldBerechnen
        {
            get { return 0; }
        }
        #endregion        
    }
}
