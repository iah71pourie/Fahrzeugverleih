using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugverleih;

namespace Fahrzeugverleih
{
    class FahrzeugVerwaltung
    {
        private List<Fahrzeug> fahrzeuge;

        DateiVerwaltung dateiVerwaltung;
        public FahrzeugVerwaltung()
        {
            dateiVerwaltung = new DateiVerwaltung();

            fahrzeuge = dateiVerwaltung.FahrzeugeAuslesen();
        }

        #region
        public List<Fahrzeug> Fahrzeuge
        {
            get { return fahrzeuge; }
        }
        #endregion

        public void FahrzeugHinzufügen(Fahrzeug fahrzeug)
        {
            if (fahrzeug is PKW)
                fahrzeuge.Add(fahrzeug);
            else if (fahrzeug is LKW)
                fahrzeuge.Add(fahrzeug);
            else
                fahrzeuge.Add(fahrzeug);
        }
        public List<Fahrzeug> FahrzeugSuchen(string kennzeichen)
        {
            List<Fahrzeug> Ergebnisse = new List<Fahrzeug>();

            foreach (Fahrzeug fahrzeug in fahrzeuge)
            {
                if (fahrzeug.Kennzeichen.Contains(kennzeichen))
                    Ergebnisse.Add(fahrzeug);
            }
            return Ergebnisse;
        }
        public double GesammteSteuerschuldBerechnen()
        {
            double steuerschuld = 0.0;

            foreach (Fahrzeug fahrzeug in fahrzeuge)
            {
                steuerschuld += fahrzeug.SteuerschuldBerechnen;
            }

            return steuerschuld;
        }
    }
}
