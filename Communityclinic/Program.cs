using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityClinic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Patientlist()); // open the input form directly  
=======
            Application.Run(new SearchForm()); // open the input form directly        }
>>>>>>> 1051ccedbb3ece6b6d9782d7eb82947cde417dc2
        }
    }
}

