using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverleih
{
    public partial class ParkhausForm : Form
    {
        Parkhaus parkhaus;

        public ParkhausForm()
        {
            InitializeComponent();
        }

        #region Eigenschaften
        public Parkhaus Parkhaus
        {
            get { return parkhaus; }
            set { parkhaus = value; }
        }
        #endregion

        private void ParkhausErstellen_Load(object sender, EventArgs e)
        {
            if (parkhaus != null)
            {
                ortTextBox.Text = parkhaus.Ort;
                plzMaskedTextBox.Text = parkhaus.PLZ.ToString();
                straßeTextBox.Text = parkhaus.Straße;

                foreach (Parkplatz parkplatz in parkhaus.Parkplätze)
                {
                    if (parkplatz.ParkplatzTyp == ParkplatzTyp.PKW)
                    {
                        if (pkwParkplätzeTextBox.Text.Length > 0)
                            pkwParkplätzeTextBox.Text = (Convert.ToInt32(pkwParkplätzeTextBox.Text) + 1).ToString();
                        else
                            pkwParkplätzeTextBox.Text = "1";
                    }
                    else if (parkplatz.ParkplatzTyp == ParkplatzTyp.LKW)
                    {
                        if (lkwParkplätzeTextBox.Text.Length > 0)
                            lkwParkplätzeTextBox.Text = (Convert.ToInt32(lkwParkplätzeTextBox.Text) + 1).ToString();
                        else
                            lkwParkplätzeTextBox.Text = "1";
                    }
                    else if (parkplatz.ParkplatzTyp == ParkplatzTyp.Motorrad)
                    {
                        if (motorradParkplätzeTextBox.Text.Length > 0)
                            motorradParkplätzeTextBox.Text = (Convert.ToInt32(motorradParkplätzeTextBox.Text) + 1).ToString();
                        else
                            motorradParkplätzeTextBox.Text = "1";
                    }

                }
            }
        }
        private void fahrzeugSpeichernButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ortTextBox.Text.Length > 0 && plzMaskedTextBox.MaskCompleted && straßeTextBox.Text.Length > 0)
                {
                    parkhaus = new Parkhaus();

                    parkhaus.Ort = ortTextBox.Text;
                    parkhaus.PLZ = Convert.ToInt32(plzMaskedTextBox.Text);
                    parkhaus.Straße = straßeTextBox.Text;

                    for (int j = 0; j < Convert.ToInt32(pkwParkplätzeTextBox.Text); j++)
                    {
                        parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.PKW));
                        parkhaus.Parkplätze[j].Stellplatznummer = "P" + (j + 1).ToString();
                    }
                    for (int j = 0; j < Convert.ToInt32(lkwParkplätzeTextBox.Text); j++)
                    {
                        parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.LKW));
                        parkhaus.Parkplätze[j + Convert.ToInt32(pkwParkplätzeTextBox.Text)].Stellplatznummer = "L" + (j + 1).ToString();
                    }
                    for (int j = 0; j < Convert.ToInt32(motorradParkplätzeTextBox.Text); j++)
                    {
                        parkhaus.Parkplätze.Add(new Parkplatz(ParkplatzTyp.Motorrad));
                        parkhaus.Parkplätze[j + Convert.ToInt32(pkwParkplätzeTextBox.Text) + Convert.ToInt32(lkwParkplätzeTextBox.Text)].Stellplatznummer = "M" + (j + 1).ToString();
                    }

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
