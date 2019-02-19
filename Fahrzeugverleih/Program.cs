using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverleih
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(@"fahrzeuge.txt"))
                File.Create(@"fahrzeuge.txt");
            if (!File.Exists(@"parkhäuser.txt"))
                File.Create(@"parkhäuser.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HauptmenüForm());
        }
    }
}
