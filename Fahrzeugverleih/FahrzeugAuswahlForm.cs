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
    public partial class FahrzeugAuswahlForm : Form
    {
        Fahrzeug fahrzeug;
        List<Fahrzeug> fahrzeuge;
        public FahrzeugAuswahlForm()
        {
            InitializeComponent();
            
            fahrzeug = null;
        }

        #region Eigenschaften
        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
        }
        public List<Fahrzeug> Fahrzeuge
        {
            set { fahrzeuge = value; }
        }
        #endregion

        private void FahrzeugAuswahl_Load(object sender, EventArgs e)
        {
            fahrzeugeDataGridView.DataSource = fahrzeuge;
            fahrzeug = null;
        }
        private void fahrzeugAuswählenButton_Click(object sender, EventArgs e)
        {
            if (fahrzeugeDataGridView.CurrentRow.Index >= 0)
                fahrzeug = fahrzeugeDataGridView.CurrentRow.DataBoundItem as Fahrzeug;

            this.Close();
        }
    }
}
