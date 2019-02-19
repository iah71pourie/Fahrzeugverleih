using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class ParkhausVerwaltung
    {
        private List<Parkhaus> parkhäuser;

        DateiVerwaltung dateiVerwaltung;

        public ParkhausVerwaltung()
        {
            dateiVerwaltung = new DateiVerwaltung();

            parkhäuser = dateiVerwaltung.ParkhäuserAuslesen();
        }

        public bool ParkhausZuweisung(Fahrzeug fahrzeug)
        {
            if (fahrzeug is PKW)
            {
                foreach (Parkhaus parkhaus in parkhäuser)
                {
                    for (int i = 0; i < parkhaus.Parkplätze.Count; i++)
                    {
                        if (parkhaus.Parkplätze[i].ParkplatzTyp == ParkplatzTyp.PKW && parkhaus.Parkplätze[i].Fahrzeug == null)
                        {
                            parkhaus.Parkplätze[i].Fahrzeug = fahrzeug;
                            return true;
                        }
                    }
                }
            }
            else if (fahrzeug is LKW)
            {
                foreach (Parkhaus parkhaus in parkhäuser)
                {
                    for (int i = 0; i < parkhaus.Parkplätze.Count; i++)
                    {
                        if (parkhaus.Parkplätze[i].ParkplatzTyp == ParkplatzTyp.LKW && parkhaus.Parkplätze[i].Fahrzeug == null)
                        {
                            parkhaus.Parkplätze[i].Fahrzeug = fahrzeug;
                            return true;
                        }
                    }
                }
            }
            else if (fahrzeug is Motorad)
            {
                foreach (Parkhaus parkhaus in parkhäuser)
                {
                    for (int i = 0; i < parkhaus.Parkplätze.Count; i++)
                    {
                        if (parkhaus.Parkplätze[i].ParkplatzTyp == ParkplatzTyp.Motorad && parkhaus.Parkplätze[i].Fahrzeug == null)
                        {
                            parkhaus.Parkplätze[i].Fahrzeug = fahrzeug;
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public Parkplatz ParkplatzSuche(Fahrzeug fahrzeug)
        {
            foreach (Parkhaus parkhaus in parkhäuser)
            {
                foreach (Parkplatz parkplatz in parkhaus.Parkplätze)
                {
                    if (parkplatz.Fahrzeug == fahrzeug)
                        return parkplatz;
                }
            }
            return null;
        }

        public void NeuesParkhausBauen(int PLZ, string Ort, string Straße, int PKWParkplätze, int LKWParkplätze, int MotoradParkplätze)
        {
            Parkhaus parkhaus = new Parkhaus();

            parkhaus.PLZ = PLZ;
            parkhaus.Ort = Ort;
            parkhaus.Straße = Straße;

            for (int i = 0; i < PKWParkplätze + LKWParkplätze + MotoradParkplätze; i++)
            {
                for (int j = 0; j <= PKWParkplätze; j++)
                {
                    parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.PKW));
                    parkhaus.Parkplätze[j].Stellplatznummer += j.ToString();
                }
                for (int j = 0; j <= LKWParkplätze; j++)
                {
                    parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.LKW));
                    parkhaus.Parkplätze[j].Stellplatznummer += j.ToString();
                }
                for (int j = 0; j <= MotoradParkplätze; j++)
                {
                    parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.Motorad));
                    parkhaus.Parkplätze[j].Stellplatznummer += j.ToString();
                }
            }

            parkhäuser.Add(parkhaus);
        }
    }
}
