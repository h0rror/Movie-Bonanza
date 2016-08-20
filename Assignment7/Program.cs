using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Assignment 7
 * Nikola Savin
 * COMP123
 * 300635434
*/

namespace MovieBonanza
{
    /*
    * <summary>
    * This class contains the main entry point for the application.
    * </summary>
    * @class Program
    */
    static class Program
    {
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Idle += Application_Idle;

            SplashForm form = new SplashForm();
            form.Show();

            Application.Run();
        }
        /*
        * <summary>
        * This method exits the application.
        * </summary>
        * @method Application_Idle
        */
        private static void Application_Idle(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
