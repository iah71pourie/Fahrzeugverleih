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
            parkhausVerwaltung.Parkhäuser.AddRange(dateiVerwaltung.ParkhäuserAuslesen());

            fahrzeugeCurrencyManager = (CurrencyManager)fahrzeugeDataGridView.BindingContext[fahrzeugVerwaltung.Fahrzeuge];
            parkhäuserCurrencyManager = (CurrencyManager)parkhäuserDataGridView.BindingContext[parkhausVerwaltung.Parkhäuser];

            fahrzeugeCurrencyManager.Refresh();
            parkhäuserCurrencyManager.Refresh();
            gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
        }
        private void HauptmenüForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dateiVerwaltung.ParkhäuserLöschen(dateiVerwaltung.ParkhäuserAuslesen());

            dateiVerwaltung.FahrzeugeSpeichern(fahrzeugVerwaltung.Fahrzeuge);
            dateiVerwaltung.ParkhäuserSpeichern(parkhausVerwaltung.Parkhäuser);
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
                    else
                    {
                        MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                    }
                }
                while (kennzeichenVorhanden);
            }
        }
        private void fahrzeugeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            using (FahrzeugForm fahrzeugForm = new FahrzeugForm())
            {
                bool kennzeichenVorhanden;

                Fahrzeug fahrzeug = (fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug);
                fahrzeugForm.Fahrzeug = fahrzeug;

                do
                {
                    kennzeichenVorhanden = false;
                    fahrzeugForm.ShowDialog();

                    if (fahrzeugForm.Fahrzeug != null)
                    {
                        foreach (Fahrzeug fahrzeug1 in fahrzeugVerwaltung.Fahrzeuge)
                        {
                            if (fahrzeug1.Kennzeichen == fahrzeugForm.Fahrzeug.Kennzeichen && fahrzeug1 != fahrzeug)
                                kennzeichenVorhanden = true;
                        }

                        if (!kennzeichenVorhanden)
                        {
                            fahrzeugVerwaltung.Fahrzeuge[fahrzeugVerwaltung.Fahrzeuge.IndexOf(fahrzeug)] = fahrzeugForm.Fahrzeug;

                            fahrzeugeKennzeichenSucheTextBox.Text = "";
                            fahrzeugeCurrencyManager.Refresh();
                            gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
                        }
                        else
                        {
                            MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                    }
                }
                while (kennzeichenVorhanden);
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
                foreach (Parkhaus parkhaus in parkhausVerwaltung.Parkhäuser)
                {
                    foreach (Parkplatz parkplatz in parkhaus.Parkplätze)
                    {
                        if (parkplatz.Fahrzeug.Equals(fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug))
                            if (parkplatz.ParkplatzTyp.Equals(ParkplatzTyp.PKW))
                                parkplatz.Fahrzeug = new PKW();
                            else if (parkplatz.ParkplatzTyp.Equals(ParkplatzTyp.LKW))
                                parkplatz.Fahrzeug = new LKW();
                            else if (parkplatz.ParkplatzTyp.Equals(ParkplatzTyp.Motorrad))
                                parkplatz.Fahrzeug = new Motorrad();
                    }
                }

                fahrzeugVerwaltung.Fahrzeuge.Remove(fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug);

                fahrzeugeCurrencyManager.Refresh();
                parkhäuserCurrencyManager.Refresh();
                gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
            }
        }
        #endregion

        #region Parkhäuser
        private void parkhäuserDataGridView_DoubleClick(object sender, EventArgs e)
        {
            using (ParkhausForm parkhausForm = new ParkhausForm())
            {
                bool parkhausVorhanden;
                do
                {
                    parkhausVorhanden = false;
                    Parkhaus parkhaus = (parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus);
                    parkhausForm.Parkhaus = parkhaus;

                    parkhausForm.ShowDialog();

                    if (parkhausForm.Parkhaus != null)
                    {
                        foreach (Parkhaus parkhaus1 in parkhausVerwaltung.Parkhäuser)
                        {
                            if (parkhausForm.Parkhaus.Ort + parkhausForm.Parkhaus.PLZ.ToString() + parkhausForm.Parkhaus.Straße == parkhaus1.Ort + parkhaus1.PLZ.ToString() + parkhaus1.Straße && parkhaus1 != parkhaus)
                                parkhausVorhanden = true;
                        }

                        if (!parkhausVorhanden)
                        {
                            parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhaus)] = parkhausForm.Parkhaus;

                            parkhäuserCurrencyManager.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                    }
                }
                while (parkhausVorhanden);
            }
        }
        private void parkhausErstellenButton_Click(object sender, EventArgs e)
        {
            using (ParkhausForm parkhausForm = new ParkhausForm())
            {
                bool parkhausVorhanden;
                do
                {
                    parkhausVorhanden = false;

                    parkhausForm.ShowDialog();

                    if (parkhausForm.Parkhaus != null)
                    {
                        foreach (Parkhaus parkhaus in parkhausVerwaltung.Parkhäuser)
                        {
                            if (parkhausForm.Parkhaus.Ort + parkhausForm.Parkhaus.PLZ.ToString() + parkhausForm.Parkhaus.Straße == parkhaus.Ort + parkhaus.PLZ.ToString() + parkhaus.Straße)
                                parkhausVorhanden = true;
                        }

                        if (!parkhausVorhanden)
                        {
                            parkhausVerwaltung.Parkhäuser.Add(parkhausForm.Parkhaus);
                            parkhäuserCurrencyManager.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                    }
                }
                while (parkhausVorhanden);
            }
        }
        private void parkhausLöschenButton_Click(object sender, EventArgs e)
        {
            if (parkhäuserDataGridView.CurrentRow.Index >= 0 && MessageBox.Show("Sind Sie sich sicher, dass Sie dieses Parkhaus löschen wollen?", "Parkhaus löschen?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                parkhausVerwaltung.Parkhäuser.Remove(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus);
                parkhäuserCurrencyManager.Refresh();
            }
        }
        private void parkhäuserKennzeichenSucheTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Parkhaus> ausgewählteParkhäuser = new List<Parkhaus>();

            if (parkhäuserKennzeichenSucheTextBox.Text.Length > 0 && parkhäuserKennzeichenSucheTextBox.Text.Last() == ' ' && parkhäuserKennzeichenSucheTextBox.Text.Count(c => c == '-') < 1)
            {
                parkhäuserKennzeichenSucheTextBox.Text = parkhäuserKennzeichenSucheTextBox.Text.Remove(parkhäuserKennzeichenSucheTextBox.Text.Length - 1, 1) + '-';
                parkhäuserKennzeichenSucheTextBox.SelectionStart = parkhäuserKennzeichenSucheTextBox.Text.Length;
            }

            foreach (Parkhaus parkhaus in parkhausVerwaltung.Parkhäuser)
            {
                for (int i = 0; i < parkhaus.Parkplätze.Count; i++)
                {
                    if (parkhaus.Parkplätze[i].Fahrzeug.Kennzeichen.Contains(parkhäuserKennzeichenSucheTextBox.Text.ToUpper()))
                    {
                        ausgewählteParkhäuser.Add(parkhaus);
                        i = parkhaus.Parkplätze.Count;
                    }
                }
            }

            parkhäuserCurrencyManager.SuspendBinding();

            foreach (DataGridViewRow Zeile in parkhäuserDataGridView.Rows)
            {
                if (ausgewählteParkhäuser.Count == 0)
                {
                    Zeile.Visible = false;
                }
                else
                {
                    foreach (Parkhaus parkhaus in ausgewählteParkhäuser)
                    {
                        if (!Zeile.DataBoundItem.Equals(parkhaus))
                            Zeile.Visible = false;
                        else
                            Zeile.Visible = true;
                    }
                }
            }

            parkhäuserCurrencyManager.ResumeBinding();
        }

        private void parkhäuserDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            fahrzeugeListBox.Items.Clear();

            try
            {
                foreach (Parkplatz parkplatz in (parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze)
                {
                    fahrzeugeListBox.Items.Add(parkplatz.Stellplatznummer + ": " + parkplatz.Fahrzeug.Kennzeichen);
                }
            }
            catch { }
        }
        private void fahrzeugeListBox_DoubleClick(object sender, EventArgs e)
        {
            using (FahrzeugForm fahrzeugForm = new FahrzeugForm())
            {
                bool kennzeichenVorhanden;

                Fahrzeug fahrzeug = null;

                foreach (Parkplatz parkplatz in (parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze)
                {
                    if (parkplatz.Stellplatznummer.Equals(fahrzeugeListBox.SelectedItem.ToString().Split(':')))
                        fahrzeug = parkplatz.Fahrzeug;
                }

                if (fahrzeug != null)
                {
                    fahrzeugForm.Fahrzeug = fahrzeug;

                    do
                    {
                        kennzeichenVorhanden = false;
                        fahrzeugForm.ShowDialog();

                        if (fahrzeugForm.Fahrzeug != null)
                        {
                            foreach (Fahrzeug fahrzeug1 in fahrzeugVerwaltung.Fahrzeuge)
                            {
                                if (fahrzeug1.Kennzeichen == fahrzeugForm.Fahrzeug.Kennzeichen && fahrzeug1 != fahrzeug)
                                    kennzeichenVorhanden = true;
                            }

                            if (!kennzeichenVorhanden)
                            {
                                fahrzeugVerwaltung.Fahrzeuge[fahrzeugVerwaltung.Fahrzeuge.IndexOf(fahrzeug)] = fahrzeugForm.Fahrzeug;

                                fahrzeugeKennzeichenSucheTextBox.Text = "";
                                fahrzeugeCurrencyManager.Refresh();
                                gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";
                            }
                            else
                            {
                                MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Das Kennzeichen ist bereits vergeben!");
                        }
                    }
                    while (kennzeichenVorhanden);
                }
            }
        }

        private void parkplatzZuweisenButton_Click(object sender, EventArgs e)
        {
            using (FahrzeugAuswahl fahrzeugAuswahl = new FahrzeugAuswahl())
            {
                bool fahrzeugBereitsAbgestellt = false;

                do
                {
                    fahrzeugBereitsAbgestellt = false;

                    fahrzeugAuswahl.Fahrzeuge = fahrzeugVerwaltung.Fahrzeuge;

                    fahrzeugAuswahl.ShowDialog();

                    for (int i = 0; i < parkhausVerwaltung.Parkhäuser.Count; i++)
                    {
                        for (int j = 0; j < parkhausVerwaltung.Parkhäuser[i].Parkplätze.Count; j++)
                        {
                            if (parkhausVerwaltung.Parkhäuser[i].Parkplätze[j].Fahrzeug.Kennzeichen == fahrzeugAuswahl.Fahrzeug.Kennzeichen)
                            {
                                fahrzeugBereitsAbgestellt = true;
                                j = parkhausVerwaltung.Parkhäuser[i].Parkplätze.Count;
                                i = parkhausVerwaltung.Parkhäuser.Count - 1;
                            }
                        }
                    }

                    if (!fahrzeugBereitsAbgestellt && fahrzeugAuswahl.Fahrzeug != null && fahrzeugeListBox.SelectedIndex >= 0)
                    {
                        for (int i = 0; i < (parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze.Count; i++)
                        {
                            if ((parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze[i].Stellplatznummer.Equals(fahrzeugeListBox.SelectedItem.ToString().Split(':')[0]))
                            {
                                if (((parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze[i].ParkplatzTyp.Equals(ParkplatzTyp.PKW) && fahrzeugAuswahl.Fahrzeug is PKW) || ((parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze[i].ParkplatzTyp.Equals(ParkplatzTyp.LKW) && fahrzeugAuswahl.Fahrzeug is LKW) || ((parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze[i].ParkplatzTyp.Equals(ParkplatzTyp.Motorrad) && fahrzeugAuswahl.Fahrzeug is Motorrad))
                                {
                                    parkhausVerwaltung.Parkhäuser[parkhäuserDataGridView.CurrentRow.Index].Parkplätze[i].Fahrzeug = fahrzeugAuswahl.Fahrzeug;

                                    i = (parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze.Count;

                                    parkhäuserCurrencyManager.Refresh();
                                    parkhäuserDataGridView_SelectionChanged(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Der ParkplatzTyp enspricht nicht dem Typen des Ausgewählten Fahrzeuges!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dieses Fahrzeug wurde bereits an einem anderem Stellplatz untergebracht!");
                    }
                }
                while (fahrzeugBereitsAbgestellt);
            }
        }
        private void parkplatzTrennenButton_Click(object sender, EventArgs e)
        {
            if (parkhäuserDataGridView.CurrentRow.Index >= 0 && fahrzeugeListBox.SelectedIndex >= 0 && MessageBox.Show("Sind Sie sich sicher, dass Sie dieses Fahrzeug von dem Parkplatz trennen wollen?", "Parkplatz trennen?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                if (parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus)].Parkplätze[fahrzeugeListBox.SelectedIndex].Fahrzeug is PKW)
                    parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus)].Parkplätze[fahrzeugeListBox.SelectedIndex].Fahrzeug = new PKW();
                else if (parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus)].Parkplätze[fahrzeugeListBox.SelectedIndex].Fahrzeug is LKW)
                    parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus)].Parkplätze[fahrzeugeListBox.SelectedIndex].Fahrzeug = new LKW();
                else
                    parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus)].Parkplätze[fahrzeugeListBox.SelectedIndex].Fahrzeug = new Motorrad();

                parkhäuserDataGridView_SelectionChanged(sender, e);
                parkhäuserCurrencyManager.Refresh();
            }
        }
        #endregion
    }
}
