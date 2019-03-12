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
    // DATA GRID VIEW
    public partial class HauptmenüForm : Form
    {
        FahrzeugVerwaltung fahrzeugVerwaltung;
        ParkhausVerwaltung parkhausVerwaltung;

        DateiVerwaltung dateiVerwaltung;

        public HauptmenüForm()
        {
            InitializeComponent();

            fahrzeugVerwaltung = new FahrzeugVerwaltung();
            parkhausVerwaltung = new ParkhausVerwaltung();

            dateiVerwaltung = new DateiVerwaltung();
        }
        
        public void fahrzeugeListBoxUpdaten(List<Fahrzeug> fahrzeuge)
        {
            fahrzeugeListBox.Items.Clear();

            foreach (Fahrzeug fahrzeug in fahrzeuge)
            {
                fahrzeugeListBox.Items.Add(fahrzeug.Kennzeichen);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fahrzeugVerwaltung.Fahrzeuge.AddRange(dateiVerwaltung.FahrzeugeAuslesen());

            fahrzeugeListBoxUpdaten(fahrzeugVerwaltung.Fahrzeuge);
        }
        private void HauptmenüForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dateiVerwaltung.FahrzeugeSpeichern(fahrzeugVerwaltung.Fahrzeuge);
        }

        private void fahrzeugErstellenButton_Click(object sender, EventArgs e)
        {
            using (FahrzeugErstellen fahrzeugErstellenForm = new FahrzeugErstellen())
            {
                bool kennzeichenVorhanden;

                do
                {
                    kennzeichenVorhanden = false;

                    fahrzeugErstellenForm.ShowDialog();

                    if (fahrzeugErstellenForm.Fahrzeug != null)
                    {
                        foreach (Fahrzeug fahrzeug in fahrzeugVerwaltung.Fahrzeuge)
                        {
                            if (fahrzeug.Kennzeichen == fahrzeugErstellenForm.Fahrzeug.Kennzeichen)
                                kennzeichenVorhanden = true;
                        }

                        if (!kennzeichenVorhanden)
                        {
                            fahrzeugVerwaltung.FahrzeugHinzufügen(fahrzeugErstellenForm.Fahrzeug);
                            fahrzeugeListBox.Items.Add(fahrzeugErstellenForm.Fahrzeug.Kennzeichen);
                        }
                        else
                        {
                            MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                        }
                    }
                }
                while (kennzeichenVorhanden);
            }
        }
        private void fahrzeugeListBox_DoubleClick(object sender, EventArgs e)
        {
            int ausgewähltesFahrzeug = 0;

            using (FahrzeugBearbeiten fahrzeugBearbeitenForm = new FahrzeugBearbeiten())
            {
                for (int i = 0; i < fahrzeugVerwaltung.Fahrzeuge.Count; i++)
                {
                    if (fahrzeugVerwaltung.Fahrzeuge[i].Kennzeichen == fahrzeugeListBox.SelectedItem.ToString())
                    {
                        if (fahrzeugVerwaltung.Fahrzeuge[i] is PKW)
                            fahrzeugBearbeitenForm.Fahrzeug = (fahrzeugVerwaltung.Fahrzeuge[i] as PKW);
                        else if (fahrzeugVerwaltung.Fahrzeuge[i] is LKW)
                            fahrzeugBearbeitenForm.Fahrzeug = (fahrzeugVerwaltung.Fahrzeuge[i] as LKW);
                        else if (fahrzeugVerwaltung.Fahrzeuge[i] is Motorrad)
                            fahrzeugBearbeitenForm.Fahrzeug = (fahrzeugVerwaltung.Fahrzeuge[i] as Motorrad);

                        ausgewähltesFahrzeug = i;
                    }
                }
                if (fahrzeugBearbeitenForm.Fahrzeug == null)
                    MessageBox.Show("ERROR 404!");

                fahrzeugBearbeitenForm.ShowDialog();

                fahrzeugVerwaltung.Fahrzeuge[ausgewähltesFahrzeug] = fahrzeugBearbeitenForm.Fahrzeug;
                sucheTextBox.Text = "";
                fahrzeugeListBoxUpdaten(fahrzeugVerwaltung.Fahrzeuge);
            }
        }
        private void sucheTextBox_TextChanged(object sender, EventArgs e)
        {
            fahrzeugeListBoxUpdaten(fahrzeugVerwaltung.FahrzeugSuchen(sucheTextBox.Text));
        }
        private void fahrzeugLöschenButton_Click(object sender, EventArgs e)
        {
            if (fahrzeugeListBox.SelectedIndex >= 0)
            {
                for (int i = 0; i < fahrzeugVerwaltung.Fahrzeuge.Count; i++)
                {
                    if (fahrzeugVerwaltung.Fahrzeuge[i].Kennzeichen == fahrzeugeListBox.SelectedItem.ToString())
                    {
                        fahrzeugVerwaltung.Fahrzeuge.Remove(fahrzeugVerwaltung.Fahrzeuge[i]);
                        fahrzeugeListBoxUpdaten(fahrzeugVerwaltung.Fahrzeuge);
                    }
                }
            }
        }
    }
}
