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

            herstellerComboBox.Items.AddRange(new string[] { "Audi",
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
            "Volvo"});
        }

        #region Eigenschaften
        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
        }
        #endregion

        private void fahrzeugArtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fahrzeugSpeichernButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (kennzeichenMaskedTextBox.MaskCompleted)
                {
                    switch (fahrzeugArtComboBox.Text)
                    {
                        case "PKW":
                            fahrzeug = new PKW();
                            break;

                        case "LKW":
                            fahrzeug = new LKW();
                            break;

                        case "Motorad":
                            fahrzeug = new Motorrad();
                            break;
                    }
                    MessageBox.Show(kennzeichenMaskedTextBox.Text);
                    fahrzeug.Kennzeichen = kennzeichenMaskedTextBox.Text;

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
