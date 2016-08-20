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
    * This class contains the SelectionForm.
    * </summary>
    * @class SelectionForm
    */
    public partial class SelectionForm : Form
    {

        public SelectionForm()
        {
            InitializeComponent();
            MovieDropDownList.DataSource = Movie.List;
            MovieDropDownList.DisplayMember = "Title";
        }
        /*
        * <summary>
        * This method updates the movie when the user selects one with the MovieDropDownList. 
        * </summary>
        * @method MovieDropDownList_SelectedValueChanged
        */
        private void MovieDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)MovieDropDownList.SelectedItem;
            TitleTextBox.Text = movie.Title;
            CategoryTextBox.Text = movie.Category.Name;
            CostTextBox.Text = string.Format("{0:C}", movie.Category.Cost);
            CoverPictureBox.Image = movie.Cover;
        }
        /*
        * <summary>
        * </summary>
        * @method NextBtn_Click
        */
        private void NextBtn_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)MovieDropDownList.SelectedItem;
            OrderForm order = new OrderForm(movie);
            order.Show();

            this.Close();
        }

        private void CostLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
