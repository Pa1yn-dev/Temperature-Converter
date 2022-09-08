using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter__UI_
{
    public partial class Form1 : Form
    {
        // Created by Peter Hamilton
        public double userinput;
        public string userrawinput;
        public double Useroutput;
        public int usersel;


        public Form1()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            usersel = Convert.ToInt32(listBox1.GetItemText(listBox1.SelectedIndex));

            //testing
            //string userselteststring = Convert.ToString(usersel);
            //MessageBox.Show(userselteststring);

            

            
        }

        private void convert_Click(object sender, EventArgs e)
        {
            Button convertbuttonclick = new Button();
            if (convertbuttonclick.Enabled == true)
            {
                switch (usersel)
                {
                    case 0:
                        Celsu();
                        MessageBox.Show(Convert.ToString("Fahrenheit: " + Useroutput + "°F"));

                        break;
                    case 1:
                        Farenh();
                        MessageBox.Show(Convert.ToString("Celsuis: " + Useroutput + "°C"));

                        break;
                    case 2:
                        CeltoKel();
                        MessageBox.Show(Convert.ToString("Kelvin: " + Useroutput + "K"));

                        break;
                    case 3:
                        faToKel();
                        MessageBox.Show(Convert.ToString("Kelvin: " + Useroutput + "K"));

                        break;
                    case 4:
                        keltofar();
                        MessageBox.Show(Convert.ToString("Fahrenheit: " + Useroutput + "°F"));

                        break;
                    case 5:
                        Keltocel();
                        MessageBox.Show(Convert.ToString("Celsuis: " + Useroutput + "°C"));

                        break;
                    default:
                        break;
                }

                

            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

            userrawinput = textBox1.Text;



        }

        public void label1_Click(object sender, EventArgs e)
        {

        }


        private void UserInsert_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        // Celsuis to Fahrenheit
        public void Celsu()
        {
            userinput = Convert.ToDouble(userrawinput);
         
            Useroutput = (userinput * 9/5) + 32;
        }

        // Fahrenheit to celsuis
        public void Farenh()
        {
            userinput = Convert.ToDouble(userrawinput);

            Useroutput = (userinput - 32) * 5 / 9;
        }



        // Celsuis to kelvin
        public void CeltoKel()
        {
            userinput = Convert.ToDouble(userrawinput);

            Useroutput = userinput + 273.15;
        }

        // Fahrenheit to kelvin
        public void faToKel()
        {
            userinput = Convert.ToDouble(userrawinput);

            Useroutput = (userinput - 32) * 5/9 + 273.15;
        }

        // Kelvin to Fahrenheit
        public void keltofar()
        {
            userinput = Convert.ToDouble(userrawinput);

            Useroutput = (userinput - 273.15) * 9/5 + 32;
        }

        // Kelvin to celsuis
        public void Keltocel()
        {
            userinput = Convert.ToDouble(userrawinput);

            Useroutput = userinput - 273.15;

        }

        
    }
}









