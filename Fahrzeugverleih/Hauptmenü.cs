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

        CurrencyManager fahrzeugeCurrencyManager;
        CurrencyManager parkhäuserCurrencyManager;

        public HauptmenüForm()
        {
            InitializeComponent();

            fahrzeugVerwaltung = new FahrzeugVerwaltung();
            parkhausVerwaltung = new ParkhausVerwaltung();
            dateiVerwaltung = new DateiVerwaltung();

            fahrzeugeDataGridView.DataSource = fahrzeugVerwaltung.Fahrzeuge;
            parkhäuserDataGridView.DataSource = parkhausVerwaltung.Parkhäuser;
        }

        private void HauptmenüForm_Load(object sender, EventArgs e)
        {
            fahrzeugVerwaltung.Fahrzeuge.AddRange(dateiVerwaltung.FahrzeugeAuslesen());
            
            fahrzeugeCurrencyManager = (CurrencyManager)fahrzeugeDataGridView.BindingContext[fahrzeugVerwaltung.Fahrzeuge];
            parkhäuserCurrencyManager = (CurrencyManager)parkhäuserDataGridView.BindingContext[parkhausVerwaltung.Parkhäuser];

            fahrzeugeCurrencyManager.Refresh();
            parkhäuserCurrencyManager.Refresh();
            gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
        }
        private void HauptmenüForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dateiVerwaltung.FahrzeugeSpeichern(fahrzeugVerwaltung.Fahrzeuge);
        }

        #region Fahrzeuge
        private void fahrzeugErstellenButton_Click(object sender, EventArgs e)
        {
            using (FahrzeugForm fahrzeugErstellenForm = new FahrzeugForm())
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
                            fahrzeugeCurrencyManager.Refresh();
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
            using (FahrzeugForm fahrzeugBearbeitenForm = new FahrzeugForm())
            {
                Fahrzeug fahrzeug = (fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug);
                fahrzeugBearbeitenForm.Fahrzeug = fahrzeug;
                
                fahrzeugBearbeitenForm.ShowDialog();

                fahrzeugVerwaltung.Fahrzeuge[fahrzeugVerwaltung.Fahrzeuge.IndexOf(fahrzeug)] = fahrzeugBearbeitenForm.Fahrzeug;

                fahrzeugeKennzeichenSucheTextBox.Text = "";
                fahrzeugeCurrencyManager.Refresh();
                gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
            }
        }
        private void fahrzeugeKennzeichenSucheTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fahrzeugeKennzeichenSucheTextBox.Text.Length > 0 && fahrzeugeKennzeichenSucheTextBox.Text.Last() == ' ' && fahrzeugeKennzeichenSucheTextBox.Text.Count(c => c == '-') < 1)
            {
                fahrzeugeKennzeichenSucheTextBox.Text = fahrzeugeKennzeichenSucheTextBox.Text.Remove(fahrzeugeKennzeichenSucheTextBox.Text.Length - 1, 1) + '-';
                fahrzeugeKennzeichenSucheTextBox.SelectionStart = fahrzeugeKennzeichenSucheTextBox.Text.Length;
            }

            fahrzeugeCurrencyManager.SuspendBinding();

            foreach (DataGridViewRow Zeile in fahrzeugeDataGridView.Rows)
            {
                if (!Zeile.Cells[0].Value.ToString().Contains(fahrzeugeKennzeichenSucheTextBox.Text.ToUpper()))
                    Zeile.Visible = false;
                else
                    Zeile.Visible = true;
            }

            fahrzeugeCurrencyManager.ResumeBinding();
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
                        fahrzeugeCurrencyManager.Refresh();
                        gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";

                        i = fahrzeugVerwaltung.Fahrzeuge.Count() + 1;
                    }
                }
            }
        }
        #endregion

        #region Parkhäuser
        private void parkhäuserDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }
        private void parkhausErstellenButton_Click(object sender, EventArgs e)
        {

        }
        private void parkhausLöschenButton_Click(object sender, EventArgs e)
        {

        }
        private void parkhäuserKennzeichenSucheTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void fahrzeugeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
