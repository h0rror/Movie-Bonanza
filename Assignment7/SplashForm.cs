using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    /*
    * <summary>
    * This class contains the SplashForm.
    * </summary>
    * @class SplashForm
    */
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            // loads all the movies
            Console.WriteLine(Movie.List.Length);
        }

        /*
        * <summary>
        * This method shows the SelectionForm.
        * </summary>
        * @method Timer_Tick
        */
        private void Timer_Tick(object sender, EventArgs e)
        {
            SelectionForm form = new SelectionForm();
            form.Show();

            this.Close();
        }
    }
}
