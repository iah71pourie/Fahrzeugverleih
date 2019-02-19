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
        public void fahrzeugeListBoxHinzufügen()
        {
            foreach (Fahrzeug fahrzeug in fahrzeugVerwaltung.Fahrzeuge)
            {
                fahrzeugeListBox.Items.Add(fahrzeug.Kennzeichen);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            fahrzeugeListBoxHinzufügen();
        }

        private void fahrzeugErstellenButton_Click(object sender, EventArgs e)
        {
            using (FahrzeugErstellenForm fahrzeugErstellenForm = new FahrzeugErstellenForm())
            {
                fahrzeugErstellenForm.ShowDialog();

                if (fahrzeugErstellenForm.Fahrzeug != null)
                {
                    fahrzeugVerwaltung.FahrzeugHinzufügen(fahrzeugErstellenForm.Fahrzeug);
                    fahrzeugeListBox.Items.Add(fahrzeugErstellenForm.Fahrzeug);
                }
            }
        }

        private void sucheTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
