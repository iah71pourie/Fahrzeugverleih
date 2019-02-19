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
    public partial class FahrzeugErstellenForm : Form
    {
        private Fahrzeug fahrzeug;

        public FahrzeugErstellenForm()
        {
            InitializeComponent();
            
            /*switch ()
            {
                case "PKW":
                    fahrzeug = new PKW();
                    break;

                case "LKW":
                    fahrzeug = new LKW();
                    break;

                case "Motorad":
                    fahrzeug = new Motorad();
                    break;

                default:
                    fahrzeug = new PKW();
                    break;
            }*/
        }

        #region Eigenschaften
        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
        }
        #endregion

        private void fahrzeugErstellenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
