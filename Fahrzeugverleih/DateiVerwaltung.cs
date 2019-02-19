using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class DateiVerwaltung
    {
        private List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();
        private List<Parkhaus> parkhäuser = new List<Parkhaus>();

        public void Speichern(List<Fahrzeug> fahrzeuge, List<Parkhaus> parkhäuser)
        {
            #region Fahrzeuge
            using (StreamWriter writer = new StreamWriter(@"fahrzeuge.txt"))
            {
                foreach (Fahrzeug fahrzeug in fahrzeuge)
                {
                    writer.Write(fahrzeug.Hersteller + ";" + fahrzeug.Modell + ";" +
                        fahrzeug.Kennzeichen + ";" + fahrzeug.Zulassungsjahr.ToString() + ";" + fahrzeug.Anschaffungspreis.ToString() + ";");

                    if (fahrzeug is PKW)
                    {
                        writer.Write((fahrzeug as PKW).Hubraum.ToString() + ";" + (fahrzeug as PKW).Leistung.ToString() + ";" +
                            (fahrzeug as PKW).Schadstoffklasse + ";");
                    }
                    else if (fahrzeug is LKW)
                    {
                        writer.Write((fahrzeug as LKW).Zuladung.ToString() + ";" + (fahrzeug as LKW).AchsenAnzahl.ToString() + ";");
                    }
                    else
                    {
                        writer.Write((fahrzeug as Motorad).Hubraum.ToString() + ";");
                    }

                    writer.WriteLine();
                }
            }
            #endregion

            #region Parkhäuser
            using (StreamWriter writer = new StreamWriter(@"parkhäuser.txt"))
            {
                foreach (Parkhaus parkhaus in parkhäuser)
                {
                    writer.Write(parkhaus.PLZ.ToString() + ";" + parkhaus.Ort.ToString() + ";" + parkhaus.Straße.ToString() + ";");
                    writer.WriteLine();
                }
            }

            foreach (Parkhaus parkhaus in parkhäuser)
            {
                if (!File.Exists(@"" + parkhaus.PLZ.ToString() + parkhaus.Ort.ToString() + parkhaus.Straße.ToString() + ".txt"))
                    File.Create(@"" + parkhaus.PLZ.ToString() + parkhaus.Ort.ToString() + parkhaus.Straße.ToString() + ".txt");

                using (StreamWriter writer = new StreamWriter(@"" + parkhaus.PLZ.ToString() + parkhaus.Ort.ToString() + parkhaus.Straße.ToString() + ".txt"))
                {
                    foreach (Parkplatz parkplatz in parkhaus.Parkplätze)
                    {
                        writer.Write(parkplatz.ParkplatzTyp.ToString() + ";" + parkplatz.Stellplatznummer.ToString() + ";");

                        writer.Write(parkplatz.Fahrzeug.Hersteller.ToString() + ";" + parkplatz.Fahrzeug.Modell.ToString() + ";" +
                            parkplatz.Fahrzeug.Kennzeichen.ToString() + ";" + parkplatz.Fahrzeug.Zulassungsjahr.ToString() + ";" +
                            parkplatz.Fahrzeug.Anschaffungspreis.ToString() + ";");

                        writer.WriteLine();
                    }
                }
            }
            #endregion
        }
        public List<Fahrzeug> FahrzeugeAuslesen()
        {
            string[] DateiInhalt = File.ReadAllLines(@"fahrzeuge.txt");
            string[] ZeilenInhalt;
            Fahrzeug fahrzeug;

            foreach (string Zeile in DateiInhalt)
            {
                ZeilenInhalt = Zeile.Split(';');

                switch (ZeilenInhalt.Length)
                {
                    case 8:

                        fahrzeug = new PKW();

                        fahrzeug.Hersteller = ZeilenInhalt[0];
                        fahrzeug.Modell = ZeilenInhalt[1];
                        fahrzeug.Kennzeichen = ZeilenInhalt[2];
                        fahrzeug.Zulassungsjahr = Convert.ToDateTime(ZeilenInhalt[3]);
                        fahrzeug.Anschaffungspreis = Convert.ToInt32(ZeilenInhalt[4]);
                        (fahrzeug as PKW).Hubraum = Convert.ToInt32(ZeilenInhalt[5]);
                        (fahrzeug as PKW).Leistung = Convert.ToInt32(ZeilenInhalt[6]);
                        (fahrzeug as PKW).Schadstoffklasse = Convert.ToInt32(ZeilenInhalt[7]);
                        break;

                    case 7:

                        fahrzeug = new LKW();

                        fahrzeug.Hersteller = ZeilenInhalt[0];
                        fahrzeug.Modell = ZeilenInhalt[1];
                        fahrzeug.Kennzeichen = ZeilenInhalt[2];
                        fahrzeug.Zulassungsjahr = Convert.ToDateTime(ZeilenInhalt[3]);
                        fahrzeug.Anschaffungspreis = Convert.ToInt32(ZeilenInhalt[4]);
                        (fahrzeug as LKW).Zuladung = Convert.ToInt32(ZeilenInhalt[5]);
                        (fahrzeug as LKW).AchsenAnzahl = Convert.ToInt32(ZeilenInhalt[6]);
                        break;

                    case 6:

                        fahrzeug = new Motorad();

                        fahrzeug.Hersteller = ZeilenInhalt[0];
                        fahrzeug.Modell = ZeilenInhalt[1];
                        fahrzeug.Kennzeichen = ZeilenInhalt[2];
                        fahrzeug.Zulassungsjahr = Convert.ToDateTime(ZeilenInhalt[3]);
                        fahrzeug.Anschaffungspreis = Convert.ToInt32(ZeilenInhalt[4]);
                        (fahrzeug as Motorad).Hubraum = Convert.ToInt32(ZeilenInhalt[5]);

                        break;

                    default:

                        fahrzeug = null;
                        break;
                }

                if (fahrzeug != null)
                    fahrzeuge.Add(fahrzeug);
                else
                    MessageBox.Show("Daten sind Fehlerhaft");
            }

            return fahrzeuge;
        }
        public List<Parkhaus> ParkhäuserAuslesen()
        {
            string[] ParkhäuserDateiInhalt = File.ReadAllLines(@"parkhäuser.txt");
            string[] ParkhäuserZeilenInhalt;
            string[] ParkhausZeilenInhalt;
            Parkhaus parkhaus = new Parkhaus();

            foreach (string ParkhäuserZeile in ParkhäuserDateiInhalt)
            {
                ParkhäuserZeilenInhalt = ParkhäuserZeile.Split(';');

                parkhaus.PLZ = Convert.ToInt32(ParkhäuserZeilenInhalt[0]);
                parkhaus.Ort = ParkhäuserZeilenInhalt[1];
                parkhaus.Straße = ParkhäuserZeilenInhalt[2];

                string[] ParkhausDateiInhalt = File.ReadAllLines(@"" + parkhaus.PLZ + parkhaus.Ort + parkhaus.Straße + ".txt");

                for (int i = 0; i <= ParkhausDateiInhalt.Length; i++)
                {
                    ParkhausZeilenInhalt = ParkhausDateiInhalt[i].Split(';');

                    switch (ParkhausZeilenInhalt[0])
                    {
                        case "PKW":

                            parkhaus.Parkplätze[i].ParkplatzTyp = ParkplatzTyp.PKW;
                            break;

                        case "LKW":

                            parkhaus.Parkplätze[i].ParkplatzTyp = ParkplatzTyp.LKW;
                            break;

                        case "Motorad":

                            parkhaus.Parkplätze[i].ParkplatzTyp = ParkplatzTyp.Motorad;
                            break;

                        default:
                            break;
                    }

                    parkhaus.Parkplätze[i].Stellplatznummer = ParkhausZeilenInhalt[1];

                    switch (ParkhausZeilenInhalt.Length)
                    {
                        case 8:

                            parkhaus.Parkplätze[i].Fahrzeug = new PKW();

                            parkhaus.Parkplätze[i].Fahrzeug.Hersteller = ParkhausZeilenInhalt[0];
                            parkhaus.Parkplätze[i].Fahrzeug.Modell = ParkhausZeilenInhalt[1];
                            parkhaus.Parkplätze[i].Fahrzeug.Kennzeichen = ParkhausZeilenInhalt[2];
                            parkhaus.Parkplätze[i].Fahrzeug.Zulassungsjahr = Convert.ToDateTime(ParkhausZeilenInhalt[3]);
                            parkhaus.Parkplätze[i].Fahrzeug.Anschaffungspreis = Convert.ToInt32(ParkhausZeilenInhalt[4]);
                            (parkhaus.Parkplätze[i].Fahrzeug as PKW).Hubraum = Convert.ToInt32(ParkhausZeilenInhalt[5]);
                            (parkhaus.Parkplätze[i].Fahrzeug as PKW).Leistung = Convert.ToInt32(ParkhausZeilenInhalt[6]);
                            (parkhaus.Parkplätze[i].Fahrzeug as PKW).Schadstoffklasse = Convert.ToInt32(ParkhausZeilenInhalt[7]);
                            break;

                        case 7:

                            parkhaus.Parkplätze[i].Fahrzeug = new LKW();

                            parkhaus.Parkplätze[i].Fahrzeug.Hersteller = ParkhausZeilenInhalt[0];
                            parkhaus.Parkplätze[i].Fahrzeug.Modell = ParkhausZeilenInhalt[1];
                            parkhaus.Parkplätze[i].Fahrzeug.Kennzeichen = ParkhausZeilenInhalt[2];
                            parkhaus.Parkplätze[i].Fahrzeug.Zulassungsjahr = Convert.ToDateTime(ParkhausZeilenInhalt[3]);
                            parkhaus.Parkplätze[i].Fahrzeug.Anschaffungspreis = Convert.ToInt32(ParkhausZeilenInhalt[4]);
                            (parkhaus.Parkplätze[i].Fahrzeug as LKW).Zuladung = Convert.ToInt32(ParkhausZeilenInhalt[5]);
                            (parkhaus.Parkplätze[i].Fahrzeug as LKW).AchsenAnzahl = Convert.ToInt32(ParkhausZeilenInhalt[6]);
                            break;

                        case 6:

                            parkhaus.Parkplätze[i].Fahrzeug = new Motorad();

                            parkhaus.Parkplätze[i].Fahrzeug.Hersteller = ParkhausZeilenInhalt[0];
                            parkhaus.Parkplätze[i].Fahrzeug.Modell = ParkhausZeilenInhalt[1];
                            parkhaus.Parkplätze[i].Fahrzeug.Kennzeichen = ParkhausZeilenInhalt[2];
                            parkhaus.Parkplätze[i].Fahrzeug.Zulassungsjahr = Convert.ToDateTime(ParkhausZeilenInhalt[3]);
                            parkhaus.Parkplätze[i].Fahrzeug.Anschaffungspreis = Convert.ToInt32(ParkhausZeilenInhalt[4]);
                            (parkhaus.Parkplätze[i].Fahrzeug as Motorad).Hubraum = Convert.ToInt32(ParkhausZeilenInhalt[5]);

                            break;

                        default:

                            parkhaus.Parkplätze[i].Fahrzeug = null;
                            break;
                    }


                }

                parkhäuser.Add(parkhaus);
            }

            return parkhäuser;
        }
    }
}
