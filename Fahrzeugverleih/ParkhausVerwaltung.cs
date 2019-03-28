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
        
        public ParkhausVerwaltung()
        {
            parkhäuser = new List<Parkhaus>();
        }

        #region Eigenschaften
        public List<Parkhaus> Parkhäuser
        {
            get { return parkhäuser; }
            set { parkhäuser = value; }
        }
        #endregion

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
            else if (fahrzeug is Motorrad)
            {
                foreach (Parkhaus parkhaus in parkhäuser)
                {
                    for (int i = 0; i < parkhaus.Parkplätze.Count; i++)
                    {
                        if (parkhaus.Parkplätze[i].ParkplatzTyp == ParkplatzTyp.Motorrad && parkhaus.Parkplätze[i].Fahrzeug == null)
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
    }
}
