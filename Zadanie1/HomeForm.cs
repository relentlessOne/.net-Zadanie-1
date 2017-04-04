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


            Data.toys.Add(new Plane(12, 1, "plane"));

            Data.toys.Add(new Submarine(7, 5, "sub"));

            Data.toys.Add(new Car(2,  "car"));

            Data.toys.Add(new Computer( "comp"));

            updateToyCombobox();


        }

        private void addOnClick(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void deleteOnClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this item?", "Delete Toy", MessageBoxButtons.YesNo);



            if (Data.toys.Count != 1)
            {
                if (result.Equals(DialogResult.Yes))
                {
                    object o = (toy.SelectedItem as ComboboxItem).Value;
                    foreach (object el in Data.toys)
                    {
                        if (el.Equals(o))
                        {
                            Data.toys.Remove(o);
                            toy.Items.Remove(toy.SelectedItem);
                            toy.SelectedIndex = 0;
                            break;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("There must be at least 1 Toy");
            }


 
            
          

        }

        private void editOnClick(object sender, EventArgs e)
        {
            object o = (toy.SelectedItem as ComboboxItem).Value;
            new EditForm(o).ShowDialog();
        }

        private void toy_SelectedIndexChanged(object sender, EventArgs e)
        {
            atr1Label.Hide();
            atr2Label.Hide();
            toyLabel.Show();
            typeLabel.Show();
            atr1Info.Hide();
            atr2Info.Hide();
            toyInfo.Hide();
            typeInfo.Hide();

            String atr1 = "";
            String atr2 = "";

            object o = (toy.SelectedItem as ComboboxItem).Value;
            if (o is Car)
            {
                Car c = (Car)o;           
                atr1 = c.speed.ToString();
                typeInfo.Show();
                typeInfo.Text = "Car";
                toyInfo.Show();
                toyInfo.Text = c.name;
        
            }

            if (o is Plane)
            {
                Plane c = (Plane)o;
                atr1 = c.speed.ToString();
                atr2 = c.rise.ToString();
                typeInfo.Show();
                typeInfo.Text = "Plane";
                toyInfo.Show();
                toyInfo.Text = c.name;

            }

            if (o is Computer)
            {
                Computer c = (Computer)o;
                typeInfo.Show();
                typeInfo.Text = "Computer";
                toyInfo.Show();
                toyInfo.Text = c.name;
         
            }

            if (o is Submarine)
            {
                Submarine c = (Submarine)o;
                atr1 = c.speed.ToString();
                atr2 = c.dive.ToString();
                typeInfo.Show();
                typeInfo.Text = "Submarine";
                toyInfo.Show();
                toyInfo.Text = c.name;
   
            }

            int count = 0;
            Type objectType = o.GetType();
            Type[] ifaces = objectType.GetInterfaces();
            foreach (Type i in ifaces)
            {
                Console.WriteLine("Interface: {0}", i.Name);

                if (i.Name == "IAccelerate")
                {
                    atr1Info.Show();
                    atr1Info.Text = atr1;
                    atr1Label.Text = "Speed:";
                    atr1Label.Show();
                }

                if (i.Name == "IDive")
                {
                    atr2Info.Show();
                    atr2Info.Text = atr2;
                    atr2Label.Text = "Dive:";
                    atr2Label.Show();
                }

                if (i.Name == "IRise")
                {
                    atr2Info.Show();
                    atr2Info.Text = atr2;
                    atr2Label.Text = "Rise:";
                    atr2Label.Show();
                }

                count++;

            }


            if (count == 0)
            {
                atr1Label.Text = "No attribute available";
                atr1Label.Show();

            }



        }

        public  void updateToyCombobox()
        {


            toy.Items.Clear();


            foreach(object o in Data.toys)
            {
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

                toy.SelectedIndex = toy.Items.Add(item);

            }

        }

        public void refreshComboBox(int index)
        {
            updateToyCombobox();
            toy.SelectedIndex = index;
        }
    }
}
