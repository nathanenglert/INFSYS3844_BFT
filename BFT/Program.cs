using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFT
{
    static class Program
    {
        // Variables to carry through the program
        public static bool _runProgram = true;
        public static int _accountID = -1;
        public static string _firstName = " ";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Loop will run until use hits any exit button
            // Ensure login to multiple accounts without exiting program completely
            while (_runProgram)
            {
                Application.Run(new frmLoginScreen());

                if (_accountID != -1)
                {
                    Application.Run(new frmMainScreen());
                }
            }
        }
    }
}