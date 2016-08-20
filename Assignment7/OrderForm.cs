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
    * This class contains OrderForm.
    * </summary>
    * @class OrderForm
    */
    public partial class OrderForm : Form
    {
        private Movie _movie;
    
        public OrderForm(Movie movie)
        {
            _movie = movie;

            InitializeComponent();

            TitleTextBox.Text = movie.Title;
            CategoryTextBox.Text = movie.Category.Name;
            CoverPictureBox.Image = movie.Cover;

            CalculateOrder();
        }

        /*
        * <summary>
        * This method calculates the order ammount.
        * </summary>
        * @method CalculateOrder()
        */
        private void CalculateOrder()
        {
            CostTextBox.Text = string.Format("{0:C}", _movie.Category.Cost);

            PurchaseLabel.Visible = PurchaseCheckBox.Checked;
            PurchaseTextBox.Visible = PurchaseCheckBox.Checked;

            double subtotal = _movie.Category.Cost;
            if (PurchaseCheckBox.Checked)
            {
                subtotal = subtotal + 10;
            }

            SubTotalTextBox.Text = string.Format("{0:C}", subtotal);

            double tax = subtotal * 0.13;
            SalesTaxTextBox.Text = string.Format("{0:C}", tax);

            double total = subtotal + tax;
            GrandTotalTextBox.Text = string.Format("{0:C}", total);
        }

        /*
        * <summary>
        * This closes the program.
        * </summary>
        * @method CancelButton_Click
        */
        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectionForm sform = new SelectionForm();
            sform.Show();
            this.Close();
        }

        /*
        * <summary>
        * This method closes the application from the AboutBox.
        * </summary>
        * @method aboutToolStripMenuItem_Click
        */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutb = new AboutBox();
            aboutb.ShowDialog();

        }

        /*
        * <summary>
        * This method populates the fields on the form when the PurchaseCheckBox is checked.
        * </summary>
        * @method PurchaseCheckBox_CheckedChanged
        */
        private void PurchaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        /*
        * <summary>
        * This method closes the application in the StreamForm window.
        * </summary>
        * @method StreamButton_Click
        */
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm sform = new StreamForm(_movie, GrandTotalTextBox.Text);
            sform.Show();

            this.Close();
        }
    }
}
