using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class HomeForm : Form
    {

        private List<Type> toys = new List<Type>();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void addOnClick(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void deleteOnClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this item?", "Delete Toy", MessageBoxButtons.YesNo);
            Console.WriteLine(result);

        }

        private void editOnClick(object sender, EventArgs e)
        {
            new EditForm().ShowDialog();
        }
    }
}
