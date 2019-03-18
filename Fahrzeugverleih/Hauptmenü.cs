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
        DateiVerwaltung dateiVerwaltung;

        CurrencyManager currencyManager;

        public HauptmenüForm()
        {
            InitializeComponent();

            fahrzeugVerwaltung = new FahrzeugVerwaltung();
            parkhausVerwaltung = new ParkhausVerwaltung();
            dateiVerwaltung = new DateiVerwaltung();

            fahrzeugeDataGridView.DataSource = fahrzeugVerwaltung.Fahrzeuge;            
        }

        private void HauptmenüForm_Load(object sender, EventArgs e)
        {
            fahrzeugVerwaltung.Fahrzeuge.AddRange(dateiVerwaltung.FahrzeugeAuslesen());

            currencyManager = (CurrencyManager)fahrzeugeDataGridView.BindingContext[fahrzeugVerwaltung.Fahrzeuge];
            currencyManager.Refresh();
            gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
        }
        private void HauptmenüForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dateiVerwaltung.FahrzeugeSpeichern(fahrzeugVerwaltung.Fahrzeuge);
        }

        #region Fahrzeuge
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
                            currencyManager.Refresh();
                            gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
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
        private void fahrzeugeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int ausgewähltesFahrzeug = 0;

            using (FahrzeugBearbeiten fahrzeugBearbeitenForm = new FahrzeugBearbeiten())
            {
                for (int i = 0; i < fahrzeugVerwaltung.Fahrzeuge.Count; i++)
                {
                    if (fahrzeugVerwaltung.Fahrzeuge[i] == (fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug))
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
                currencyManager.Refresh();
                gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
            }
        }
        private void sucheTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sucheTextBox.Text.Length > 0 && sucheTextBox.Text.Last() == ' ' && sucheTextBox.Text.Count(c => c == '-') < 1)
            {
                sucheTextBox.Text = sucheTextBox.Text.Remove(sucheTextBox.Text.Length - 1, 1) + '-';
                sucheTextBox.SelectionStart = sucheTextBox.Text.Length;
            }

            currencyManager.SuspendBinding();

            foreach (DataGridViewRow Zeile in fahrzeugeDataGridView.Rows)
            {
                if (!Zeile.Cells[0].Value.ToString().Contains(sucheTextBox.Text.ToUpper()))
                    Zeile.Visible = false;
                else
                    Zeile.Visible = true;
            }

            currencyManager.ResumeBinding();
        }
        private void fahrzeugLöschenButton_Click(object sender, EventArgs e)
        {
            if (fahrzeugeDataGridView.CurrentRow.Index >= 0 && MessageBox.Show("Sind Sie sich sicher, dass Sie das Fahrzeug löschen wollen?", "Fahrzeug löschen?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                for (int i = 0; i <= fahrzeugVerwaltung.Fahrzeuge.Count; i++)
                {
                    if (fahrzeugVerwaltung.Fahrzeuge[i] == (fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug))
                    {
                        fahrzeugVerwaltung.Fahrzeuge.Remove(fahrzeugVerwaltung.Fahrzeuge[i]);
                        currencyManager.Refresh();
                        gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";

                        i = fahrzeugVerwaltung.Fahrzeuge.Count() + 1;
                    }
                }
            }
        }
        #endregion
    }
}
