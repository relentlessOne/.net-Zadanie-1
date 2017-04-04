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
    public partial class EditForm : Form
    {
        object o;
        String atr1Str = "";
        String atr2Str = "";
  

        public EditForm(object o)
        {
            InitializeComponent();
            atr1.Hide();
            atr1Text.Hide();
            atr2.Hide();
            atr2Text.Hide();

            this.o = o;

            loadDataToEdit();



        }

        private void loadDataToEdit() {
          
            if (o is Car)
            {
                Car c = (Car)o;
                atr1Str = c.speed.ToString();
                type.Text = "Car";
                name.Text = c.name;

            }

            if (o is Plane)
            {
                Plane c = (Plane)o;
                atr1Str = c.speed.ToString();
                atr2Str = c.rise.ToString();
                type.Text = "Plane";
                name.Text = c.name;

            }

            if (o is Computer)
            {
                Computer c = (Computer)o;
                type.Text = "Computer";
                name.Text = c.name;

            }

            if (o is Submarine)
            {
                Submarine c = (Submarine)o;
                atr1Str = c.speed.ToString();
                atr2Str = c.dive.ToString();
                type.Text = "Submarine";
                name.Text = c.name;

            }

            int count = 0;
            Type objectType = o.GetType();
            Type[] ifaces = objectType.GetInterfaces();
            foreach (Type i in ifaces)
            {
                Console.WriteLine("Interface: {0}", i.Name);

                if (i.Name == "IAccelerate")
                {
                    atr1.Show();
                    atr1.Text = "Speed:";
                    atr1Text.Text = atr1Str;
                    atr1Text.Show();


                }

                if (i.Name == "IDive")
                {
                    atr2.Show();
                    atr2.Text = "Dive:";
                    atr2Text.Text = atr2Str;
                    atr2Text.Show();
                }

                if (i.Name == "IRise")
                {
                    atr2.Show();
                    atr2.Text = "Rise:";
                    atr2Text.Text = atr2Str;
                    atr2Text.Show();
                }

                count++;

            }


            if (count == 0)
            {
                atr1.Text = "No attribute available";
                atr1.Show();

            }




        }

        private void okOnClick(object sender, EventArgs e)
        {



            int atr1Value;
            int atr2Value;

            int counter = 0;


            foreach (object obj in Data.toys)
            {
                if (obj.Equals(o))
                {
                    if (o is Car)
                    {
                        Car c = (Car)obj;
         
                        c.speed = Int32.Parse(atr1Text.Text);
                        c.name = name.Text;
                        Data.toys[counter] = (Object)c;
                        break;
                    }

                    if (o is Plane)
                    {
                        Plane c = (Plane)obj;
                        c.speed = Int32.Parse(atr1Text.Text);
                        c.rise = Int32.Parse(atr2Text.Text);
                        c.name = name.Text;
                        Data.toys[counter] = (Object)c;
                        break;

                    }

                    if (o is Computer)
                    {
                        Computer c = (Computer)obj;
                        c.name = name.Text;
                        Data.toys[counter] = (Object)c;
                        break;

                    }

                    if (o is Submarine)
                    {
                        Submarine c = (Submarine)o;
                        c.speed = Int32.Parse(atr1Text.Text);
                        c.dive = Int32.Parse(atr2Text.Text);
                        c.name = name.Text;
                        Data.toys[counter] = (Object)c;
                        break;

                    }

                }

                counter++;
            }

            Program.home.refreshComboBox(counter);
            this.Close();
        }

        private void cancelOnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
