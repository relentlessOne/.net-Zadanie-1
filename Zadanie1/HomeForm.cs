using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie1.Toys;

namespace Zadanie1
{
    public partial class HomeForm : Form
    {

        private List<Type> toys = new List<Type>();

        public HomeForm()
        {
            InitializeComponent();

            Data.toysTypes.Add("Car");
            Data.toysTypes.Add("Computer");
            Data.toysTypes.Add("Plane");
            Data.toysTypes.Add("Submarine");

            atr1Label.Hide();
            atr2Label.Hide();
            toyLabel.Hide();
            typeLabel.Hide();
            atr1Info.Hide();
            atr2Info.Hide();
            toyInfo.Hide();
            typeInfo.Hide();


            ComboboxItem item = new ComboboxItem();
       

     


            //MessageBox.Show((toy.SelectedItem as ComboboxItem).Value.ToString());
        }

        private void addOnClick(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void deleteOnClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this item?", "Delete Toy", MessageBoxButtons.YesNo);

            if (result.Equals(DialogResult.Yes))
            {
                object o = (toy.SelectedItem as ComboboxItem).Value;


    
                foreach(object el in Data.toys)
                {
              
                    if (el.Equals(o))
                    {
                        Data.toys.Remove(o);
                        toy.Items.Remove(toy.SelectedItem);
                        toy.SelectedIndex = 0;

                        
                        MessageBox.Show("Deleted");
                        break;
                    }
       
                }


   

            


            }
            
          

        }

        private void editOnClick(object sender, EventArgs e)
        {
            new EditForm().ShowDialog();
        }

        private void toy_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o = (toy.SelectedItem as ComboboxItem).Value;
            if (o is Car)
            {
                Car c = (Car)o;
                toyLabel.Show();
                typeLabel.Show();
                atr1Label.Show();
                atr1Label.Text = "Speed:";
                atr1Info.Show();
                atr1Info.Text = c.speed.ToString();
                typeInfo.Show();
                typeInfo.Text = "Car";
                toyInfo.Show();
                toyInfo.Text = c.name;
            }
        }

        public  void updateToyCombobox()
        {
            object o = Data.toys[Data.toys.Count - 1];
            ComboboxItem item = new ComboboxItem();


            if (o is Car)
            {
                Car c = (Car)o;
                item.Text = c.name;
                item.Value = c;
            }

            if (o is Computer)
            {
                Computer c = (Computer)o;
                item.Text = c.name;
                item.Value = c;
            }


            if (o is Plane)
            {
                Plane p = (Plane)o;
                item.Text = p.name;
                item.Value = p;
            }

            if (o is Submarine)
            {
                Submarine s = (Submarine)o;
                item.Text = s.name;
                item.Value = s;
            }

            toy.Items.Add(item);

        }
    }
}
