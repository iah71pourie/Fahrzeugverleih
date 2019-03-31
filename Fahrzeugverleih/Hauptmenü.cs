using System;
using System.Collections.Generic;
using System.Linq;
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

                Fahrzeug fahrzeug = null;

                if (fahrzeugeDataGridView.CurrentRow != null)
                {
                    fahrzeug = (fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug);
                    fahrzeugForm.Fahrzeug = fahrzeug;
                }

                do
                {
                    kennzeichenVorhanden = false;
                    if (fahrzeug != null)
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

                            if (fahrzeug.Kennzeichen != fahrzeugForm.Fahrzeug.Kennzeichen)
                            {
                                foreach (Parkhaus parkhaus in parkhausVerwaltung.Parkhäuser)
                                {
                                    foreach (Parkplatz parkplatz in parkhaus.Parkplätze)
                                    {
                                        if (parkplatz.Kennzeichen == fahrzeug.Kennzeichen)
                                        {
                                            parkplatz.Kennzeichen = fahrzeugForm.Fahrzeug.Kennzeichen;
                                            break;
                                        }
                                    }

                                }
                            }

                            fahrzeugeKennzeichenSucheTextBox.Text = "";
                            fahrzeugeCurrencyManager.Refresh();
                            gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";

                            parkhäuserCurrencyManager.Refresh();
                            parkhäuserDataGridView_SelectionChanged(sender, e);
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

            foreach (DataGridViewRow Zeile in fahrzeugeDataGridView.Rows)
            {
                if (Zeile.Visible == true)
                {
                    Zeile.Selected = true;
                    break;
                }
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
                        if (parkplatz.Kennzeichen.Equals((fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug).Kennzeichen))
                        {
                            parkplatz.Kennzeichen = "";

                            break;
                        }
                    }
                }

                fahrzeugVerwaltung.Fahrzeuge.Remove(fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug);

                fahrzeugeCurrencyManager.Refresh();
                gesammteSteuerschuldTextBox.Text = fahrzeugVerwaltung.GesammteSteuerschuldBerechnen().ToString() + " €";

                parkhäuserCurrencyManager.Refresh();
                parkhäuserDataGridView_SelectionChanged(sender, e);
            }
        }
        #endregion

        #region Parkhäuser
        private void parkhäuserDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (parkhäuserDataGridView.CurrentRow != null)
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
                    if (parkhaus.Parkplätze[i].Kennzeichen.Contains(parkhäuserKennzeichenSucheTextBox.Text.ToUpper()))
                    {
                        ausgewählteParkhäuser.Add(parkhaus);
                        break;
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
            parkhäuserDataGridView.ClearSelection();

            foreach (DataGridViewRow Zeile in fahrzeugeDataGridView.Rows)
            {
                if (Zeile.Visible)
                {
                    Zeile.Selected = true;
                    break;
                }
            }
        }

        private void parkhäuserDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            fahrzeugeListBox.Items.Clear();

            try
            {
                if (parkhäuserDataGridView.CurrentRow != null && parkhäuserDataGridView.CurrentRow.DataBoundItem != null && parkhäuserDataGridView.CurrentRow.Visible)
                {
                    foreach (Parkplatz parkplatz in (parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus).Parkplätze)
                    {
                        fahrzeugeListBox.Items.Add(parkplatz.Stellplatznummer + ": " + parkplatz.Kennzeichen);
                    }
                }
            }
            catch { }
        }
        private void parkplatzZuweisenButton_Click(object sender, EventArgs e)
        {
            using (FahrzeugAuswahlForm fahrzeugAuswahl = new FahrzeugAuswahlForm())
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
                            if (fahrzeugAuswahl.Fahrzeug == null)
                                fahrzeugBereitsAbgestellt = false;

                            else if (parkhausVerwaltung.Parkhäuser[i].Parkplätze[j].Kennzeichen == fahrzeugAuswahl.Fahrzeug.Kennzeichen)
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
                                    parkhausVerwaltung.Parkhäuser[parkhäuserDataGridView.CurrentRow.Index].Parkplätze[i].Kennzeichen = fahrzeugAuswahl.Fahrzeug.Kennzeichen;

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
                parkhausVerwaltung.Parkhäuser[parkhausVerwaltung.Parkhäuser.IndexOf(parkhäuserDataGridView.CurrentRow.DataBoundItem as Parkhaus)].Parkplätze[fahrzeugeListBox.SelectedIndex].Kennzeichen = "";

                parkhäuserDataGridView_SelectionChanged(sender, e);
                parkhäuserCurrencyManager.Refresh();
            }
        }
        private void fahrzeugeListBox_DoubleClick(object sender, EventArgs e)
        {
            if (fahrzeugeListBox.SelectedItem != null)
            {
                foreach (Fahrzeug fahrzeug in fahrzeugVerwaltung.Fahrzeuge)
                {
                    if (fahrzeugeListBox.SelectedItem.ToString().Split(' ')[1] == fahrzeug.Kennzeichen)
                    {
                        tabControl.SelectTab(0);
                        fahrzeugeKennzeichenSucheTextBox.Text = fahrzeug.Kennzeichen;

                        for (int i = 0; i < fahrzeugeDataGridView.Rows.Count; i++)
                        {
                            if (fahrzeugeDataGridView.Rows[i].Cells[0].Value.ToString() == fahrzeug.Kennzeichen)
                            {
                                fahrzeugeDataGridView.Rows[i].Selected = true;
                                fahrzeugeDataGridView_DoubleClick(new object(), new EventArgs());
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
