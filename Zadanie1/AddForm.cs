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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            loadTypesComboBox();


        }

        private void okOnClick(object sender, EventArgs e)
        {

            int atr1Value;
            int atr2Value;

            switch (toysTypesComboBox.Text)
            {
                case "Car":
           
                    if (atr1Text.Text != "" && int.TryParse(atr1Text.Text, out atr1Value) && name.Text != "")
                    {
                        Data.toys.Add(new Car(atr1Value, name.Text));
                        MessageBox.Show("Car added");
                        Program.home.updateToyCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Wrong format");
                    }
                    break;
                case "Computer":
                    if ( name.Text != "")
                    {
                        Data.toys.Add(new Computer(name.Text));
                        MessageBox.Show("Computer added");
                        Program.home.updateToyCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Wrong format");
                    }

                    break;
                case "Plane":
                 
                    if (atr1Text.Text != "" && int.TryParse(atr1Text.Text, out atr1Value) && int.TryParse(atr2Text.Text, out atr2Value) && name.Text != "")
                    {
                        Data.toys.Add(new Plane(atr1Value, atr2Value, name.Text));
                        MessageBox.Show("Plane added");
                        Program.home.updateToyCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Wrong format");
                    }

                    break;
                case "Submarine":
                    if (atr1Text.Text != "" && int.TryParse(atr1Text.Text, out atr1Value) && int.TryParse(atr2Text.Text, out atr2Value) && name.Text != "")
                    {
                        Data.toys.Add(new Submarine(atr1Value, atr2Value, name.Text));
                        MessageBox.Show("Submarine added");
                        Program.home.updateToyCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Wrong format");
                    }
                    break;
            }
        }

        private void loadTypesComboBox()
        {
            foreach (String type in Data.toysTypes)
            {
                toysTypesComboBox.Items.Add(type);
            }

            toysTypesComboBox.SelectedIndex = 0;
            toysTypesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            updateScene();
        }

        private void typeChange(object sender, EventArgs e)
        {
            Console.WriteLine(toysTypesComboBox.Text);
            updateScene();
        }

        private void updateScene()
        {

            atr1Text.Hide();
            atr2Text.Hide();
            atr1.Hide();
            atr2.Hide();

            object toCreate = new { };

            switch (toysTypesComboBox.Text)
            {
                case "Car":
                    toCreate = new Car();
                    break;
                case "Computer":
                    toCreate = new Computer();
                    break;
                case "Plane":
                    toCreate = new Plane();
                    break;
                case "Submarine":
                    toCreate = new Submarine();
                    break;
            }

            int count = 0;
            Type objectType = toCreate.GetType();
            Type[] ifaces = objectType.GetInterfaces();
            foreach (Type i in ifaces) { 
                Console.WriteLine("Interface: {0}", i.Name);

                if(i.Name == "IAccelerate")
                {
                    atr1Text.Show();     
                    atr1.Text = "Speed:";
                    atr1.Show();
                }

                if (i.Name == "IDive")
                {
                    atr2Text.Show();
                    atr2.Text = "Dive:";
                    atr2.Show();
                }

                if (i.Name == "IRise")
                {
                    atr2Text.Show();
                    atr2.Text = "Rise:";
                    atr2.Show();
                }

                count++;

            }


            if(count == 0)
            {

                atr1.Text = "No attribute available";
                atr1.Show();
            }



        }

        private void cancelOnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
