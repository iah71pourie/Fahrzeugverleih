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
            {
                using (FileStream fileStream = new FileStream(@"fahrzeuge5.txt", FileMode.Create))
                {
                    fileStream.Dispose();
                }

                Application.Restart();
            }
            if (!File.Exists(@"parkhäuser.txt"))
            {
                using (FileStream fileStream = new FileStream(@"parkhäuser.txt", FileMode.Create))
                {
                    fileStream.Dispose();
                }

                Application.Restart();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HauptmenüForm());
        }
    }
}
