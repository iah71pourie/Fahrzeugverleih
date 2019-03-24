using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrzeugverleih;

namespace Fahrzeugverleih
{
    public partial class FahrzeugErstellen : Form
    {
        private Fahrzeug fahrzeug;

        public FahrzeugErstellen()
        {
            InitializeComponent();
            
            herstellerComboBox.Items.AddRange(new string[] {
            "Audi",
            "Abarth",
            "Alfa Romeo",
            "ALPINA",
            "Aston Martin",
            "Bentley",
            "BMW",
            "Citroen",
            "DMC",
            "Ferrari",
            "Fiat",
            "Ford",
            "Hondy",
            "Hyundai",
            "Jaguar",
            "Jeep",
            "Kia",
            "Koenigsegg",
            "KTM",
            "Lada",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Maybach",
            "Mazda",
            "McLaren",
            "Mercedes-Benz",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Pagani",
            "Porsche",
            "Rolls-Royce",
            "Saab",
            "Seat",
            "Skoda",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo" });
        }

        #region Eigenschaften
        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
        }
        #endregion

        private void fahrzeugArtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Alle Controlls entfernen
            tableLayoutPanel.Controls.Remove(hubraumLabel);
            tableLayoutPanel.Controls.Remove(hubraumTextBox);
            tableLayoutPanel.Controls.Remove(leistungLabel);
            tableLayoutPanel.Controls.Remove(leistungTextBox);
            tableLayoutPanel.Controls.Remove(schadstoffklasseLabel);
            tableLayoutPanel.Controls.Remove(schadstoffklasseComboBox);
            tableLayoutPanel.Controls.Remove(achsenanzahlLabel);
            tableLayoutPanel.Controls.Remove(achsenanzahlTextBox);
            tableLayoutPanel.Controls.Remove(zuladungLabel);
            tableLayoutPanel.Controls.Remove(zuladungTextBox);

            hubraumLabel.Visible = false;
            hubraumTextBox.Visible = false;
            leistungLabel.Visible = false;
            leistungTextBox.Visible = false;
            schadstoffklasseLabel.Visible = false;
            schadstoffklasseComboBox.Visible = false;
            achsenanzahlLabel.Visible = false;
            achsenanzahlTextBox.Visible = false;
            zuladungLabel.Visible = false;
            zuladungTextBox.Visible = false;
            #endregion

            //Controlls hinzufügen, je nach Fahrzeugart
            switch (fahrzeugArtComboBox.SelectedIndex)
            {
                case 0:
                    tableLayoutPanel.Controls.Add(hubraumLabel);
                    tableLayoutPanel.Controls.Add(hubraumTextBox);
                    tableLayoutPanel.Controls.Add(leistungLabel);
                    tableLayoutPanel.Controls.Add(leistungTextBox);
                    tableLayoutPanel.Controls.Add(schadstoffklasseLabel);
                    tableLayoutPanel.Controls.Add(schadstoffklasseComboBox);

                    hubraumLabel.Visible = true;
                    hubraumTextBox.Visible = true;
                    leistungLabel.Visible = true;
                    leistungTextBox.Visible = true;
                    schadstoffklasseLabel.Visible = true;
                    schadstoffklasseComboBox.Visible = true;
                    break;

                case 1:
                    tableLayoutPanel.Controls.Add(achsenanzahlLabel);
                    tableLayoutPanel.Controls.Add(achsenanzahlTextBox);
                    tableLayoutPanel.Controls.Add(zuladungLabel);
                    tableLayoutPanel.Controls.Add(zuladungTextBox);

                    achsenanzahlLabel.Visible = true;
                    achsenanzahlTextBox.Visible = true;
                    zuladungLabel.Visible = true;
                    zuladungTextBox.Visible = true;
                    break;

                case 2:
                    tableLayoutPanel.Controls.Add(hubraumLabel);
                    tableLayoutPanel.Controls.Add(hubraumTextBox);

                    hubraumLabel.Visible = true;
                    hubraumTextBox.Visible = true;
                    break;
            }
        }
        private void fahrzeugSpeichernButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (kennzeichenMaskedTextBox.MaskCompleted && zulassungsdatumMaskedTextBox.MaskCompleted &&
                    herstellerComboBox.Text.Length > 0 && modellTextBox.Text.Length > 0)
                {
                    switch (fahrzeugArtComboBox.Text)
                    {
                        case "PKW":
                            fahrzeug = new PKW();

                            (fahrzeug as PKW).Hubraum = Convert.ToInt32(hubraumTextBox.Text);
                            (fahrzeug as PKW).Leistung = Convert.ToInt32(leistungTextBox.Text);
                            (fahrzeug as PKW).Schadstoffklasse = Convert.ToInt32(schadstoffklasseComboBox.Text);
                            break;

                        case "LKW":
                            fahrzeug = new LKW();

                            (fahrzeug as LKW).AchsenAnzahl = Convert.ToInt32(achsenanzahlTextBox.Text);
                            (fahrzeug as LKW).Zuladung = Convert.ToInt32(zuladungTextBox.Text);
                            break;

                        case "Motorad":
                            fahrzeug = new Motorrad();

                            (fahrzeug as Motorrad).Hubraum = Convert.ToInt32(hubraumTextBox.Text);
                            break;
                    }
                    fahrzeug.Kennzeichen = kennzeichenMaskedTextBox.Text.ToUpper().Replace(" ", "");
                    fahrzeug.Hersteller = herstellerComboBox.Text;
                    fahrzeug.Modell = modellTextBox.Text;
                    fahrzeug.Anschaffungspreis = Convert.ToInt32(anschaffungspreisTextBox.Text);
                    fahrzeug.Zulassungsdatum = Convert.ToDateTime(zulassungsdatumMaskedTextBox.Text);
                    
                    this.Close();
                }
                else
                    MessageBox.Show("In der Eingabe liegen Fehler vor!");
            }
            catch
            {
                MessageBox.Show("In der Eingabe liegen Fehler vor!");
            }
        }
    }
}
