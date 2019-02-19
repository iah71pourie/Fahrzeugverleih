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
    public partial class HauptmenüForm : Form
    {
        FahrzeugVerwaltung fahrzeugVerwaltung;
        ParkhausVerwaltung parkhausVerwaltung;

        public HauptmenüForm()
        {
            InitializeComponent();

            fahrzeugVerwaltung = new FahrzeugVerwaltung();
            parkhausVerwaltung = new ParkhausVerwaltung();
        }

        #region Methoden
        public void fahrzeugeListBoxHinzufügen(List<Fahrzeug> fahrzeuge)
        {
            fahrzeugeListBox.Items.Clear();

            foreach (Fahrzeug fahrzeug in fahrzeuge)
            {
                fahrzeugeListBox.Items.Add(fahrzeug.Kennzeichen);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            fahrzeugeListBoxHinzufügen(fahrzeugVerwaltung.Fahrzeuge);
        }

        private void fahrzeugErstellenButton_Click(object sender, EventArgs e)
        {
            using (FahrzeugBearbeiten fahrzeugBearbeitenForm = new FahrzeugBearbeiten())
            {
                fahrzeugBearbeitenForm.ShowDialog();

                if (fahrzeugBearbeitenForm.Fahrzeug != null)
                {
                    fahrzeugVerwaltung.FahrzeugHinzufügen(fahrzeugBearbeitenForm.Fahrzeug);
                    fahrzeugeListBox.Items.Add(fahrzeugBearbeitenForm.Fahrzeug);
                }
            }
        }

        private void sucheTextBox_TextChanged(object sender, EventArgs e)
        {
            fahrzeugeListBoxHinzufügen(fahrzeugVerwaltung.FahrzeugSuchen(sucheTextBox.Text));
        }

        private void fahrzeugeListBox_DoubleClick(object sender, EventArgs e)
        {
            using (FahrzeugBearbeiten fahrzeugBearbeitenForm = new FahrzeugBearbeiten())
            {
                fahrzeugBearbeitenForm.Fahrzeug = (fahrzeugeListBox.SelectedItem as Fahrzeug);

                fahrzeugBearbeitenForm.ShowDialog();

                for (int i = 0; i < fahrzeugVerwaltung.Fahrzeuge.Count; i++)
                {
                    if(fahrzeugVerwaltung.Fahrzeuge[i] == (fahrzeugeListBox.SelectedItem as Fahrzeug))
                    {
                        fahrzeugVerwaltung.Fahrzeuge[i] = fahrzeugBearbeitenForm.Fahrzeug;
                        sucheTextBox.Text = "";
                        fahrzeugeListBoxHinzufügen(fahrzeugVerwaltung.Fahrzeuge);
                    }
                }
            }
        }
    }
}
