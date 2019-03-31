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

        public void FahrzeugeSpeichern(List<Fahrzeug> fahrzeuge)
        {
            using (StreamWriter writer = new StreamWriter(@"fahrzeuge.txt", false))
            {
                foreach (Fahrzeug fahrzeug in fahrzeuge)
                {
                    writer.Write(fahrzeug.Hersteller + ";" + fahrzeug.Modell + ";" +
                        fahrzeug.Kennzeichen + ";" + fahrzeug.Zulassungsdatum.ToString() + ";" + fahrzeug.Anschaffungspreis.ToString() + ";");

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
                        writer.Write((fahrzeug as Motorrad).Hubraum.ToString() + ";");
                    }

                    writer.WriteLine();
                }
            }
        }
        public void ParkhäuserSpeichern(List<Parkhaus> parkhäuser)
        {
            using (StreamWriter writer = new StreamWriter(@"parkhäuser.txt", false))
            {
                foreach (Parkhaus parkhaus in parkhäuser)
                {
                    writer.Write(parkhaus.PLZ.ToString() + ";" + parkhaus.Ort.ToString() + ";" + parkhaus.Straße.ToString() + ";");
                    writer.WriteLine();
                }
            }

            foreach (Parkhaus parkhaus in parkhäuser)
            {
                using (StreamWriter writer = new StreamWriter(@"" + parkhaus.PLZ.ToString() + ";" + parkhaus.Ort.ToString() + ";" + parkhaus.Straße.ToString() + ".txt"))
                {
                    foreach (Parkplatz parkplatz in parkhaus.Parkplätze)
                    {
                        writer.Write(parkplatz.ParkplatzTyp.ToString() + ";" + parkplatz.Stellplatznummer.ToString() + ";" + parkplatz.Kennzeichen + ";");

                        writer.WriteLine();
                    }
                }
            }
        }

        public void ParkhäuserLöschen(List<Parkhaus> parkhäuser)
        {
            foreach (Parkhaus parkhaus in parkhäuser)
            {
                File.Delete(@"" + parkhaus.PLZ + ";" + parkhaus.Ort + ";" + parkhaus.Straße + ".txt");
            }
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
                    case 9:

                        fahrzeug = new PKW();

                        fahrzeug.Hersteller = ZeilenInhalt[0];
                        fahrzeug.Modell = ZeilenInhalt[1];
                        fahrzeug.Kennzeichen = ZeilenInhalt[2];
                        fahrzeug.Zulassungsdatum = Convert.ToDateTime(ZeilenInhalt[3]);
                        fahrzeug.Anschaffungspreis = Convert.ToInt32(ZeilenInhalt[4]);
                        (fahrzeug as PKW).Hubraum = Convert.ToInt32(ZeilenInhalt[5]);
                        (fahrzeug as PKW).Leistung = Convert.ToInt32(ZeilenInhalt[6]);
                        (fahrzeug as PKW).Schadstoffklasse = Convert.ToInt32(ZeilenInhalt[7]);
                        break;

                    case 8:

                        fahrzeug = new LKW();

                        fahrzeug.Hersteller = ZeilenInhalt[0];
                        fahrzeug.Modell = ZeilenInhalt[1];
                        fahrzeug.Kennzeichen = ZeilenInhalt[2];
                        fahrzeug.Zulassungsdatum = Convert.ToDateTime(ZeilenInhalt[3]);
                        fahrzeug.Anschaffungspreis = Convert.ToInt32(ZeilenInhalt[4]);
                        (fahrzeug as LKW).Zuladung = Convert.ToDouble(ZeilenInhalt[5]);
                        (fahrzeug as LKW).AchsenAnzahl = Convert.ToInt32(ZeilenInhalt[6]);
                        break;

                    case 7:

                        fahrzeug = new Motorrad();

                        fahrzeug.Hersteller = ZeilenInhalt[0];
                        fahrzeug.Modell = ZeilenInhalt[1];
                        fahrzeug.Kennzeichen = ZeilenInhalt[2];
                        fahrzeug.Zulassungsdatum = Convert.ToDateTime(ZeilenInhalt[3]);
                        fahrzeug.Anschaffungspreis = Convert.ToInt32(ZeilenInhalt[4]);
                        (fahrzeug as Motorrad).Hubraum = Convert.ToInt32(ZeilenInhalt[5]);

                        break;

                    default:

                        fahrzeug = null;
                        break;
                }

                if (fahrzeug != null)
                {
                    fahrzeuge.Add(fahrzeug);
                    fahrzeug = null;
                }
                else
                    MessageBox.Show("Daten sind Fehlerhaft");
            }

            return fahrzeuge;
        }
        public List<Parkhaus> ParkhäuserAuslesen()
        {
            string[] ParkhäuserDateiInhalt = File.ReadAllLines(@"parkhäuser.txt");  //Gesamter Dateiinhalt der Parkhausdatei
            string[] ParkhäuserZeilenInhalt;        //Einzellner Zeileninhalt der Parkhausdatei
            string[] ParkhausZeilenInhalt;          //Einzellner Zeileninhalt der Ausgewählten Parkhausdatei
            Parkhaus parkhaus = new Parkhaus();

            foreach (string ParkhäuserZeile in ParkhäuserDateiInhalt)
            {
                ParkhäuserZeilenInhalt = ParkhäuserZeile.Split(';');

                parkhaus.PLZ = Convert.ToInt32(ParkhäuserZeilenInhalt[0]);
                parkhaus.Ort = ParkhäuserZeilenInhalt[1];
                parkhaus.Straße = ParkhäuserZeilenInhalt[2];

                string[] ParkhausDateiInhalt = File.ReadAllLines(@"" + parkhaus.PLZ + ";" + parkhaus.Ort + ";" + parkhaus.Straße + ".txt");

                for (int i = 0; i < ParkhausDateiInhalt.Length; i++)
                {
                    ParkhausZeilenInhalt = ParkhausDateiInhalt[i].Split(';');

                    switch (ParkhausZeilenInhalt[0])
                    {
                        case "PKW":

                            parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.PKW));
                            break;

                        case "LKW":

                            parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.LKW));
                            break;

                        case "Motorrad":

                            parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.Motorrad));
                            break;

                        default:
                            break;
                    }

                    parkhaus.Parkplätze[i].Stellplatznummer = ParkhausZeilenInhalt[1];
                    parkhaus.Parkplätze[i].Kennzeichen = ParkhausZeilenInhalt[2];
                }

                parkhäuser.Add(parkhaus);
            }

            return parkhäuser;
        }
    }
}