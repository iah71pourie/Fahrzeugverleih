using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverleih
{
    class ParkhausVerwaltung
    {
        private List<Parkhaus> parkhäuser;
        
        public ParkhausVerwaltung()
        {
            parkhäuser = new List<Parkhaus>();
        }

        #region Eigenschaften
        public List<Parkhaus> Parkhäuser
        {
            get { return parkhäuser; }
            set { parkhäuser = value; }
        }
        #endregion
    }
}
