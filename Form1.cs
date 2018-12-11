using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Area = double.Parse(textBox1.Text);
            double Space = double.Parse(textBox2.Text);
            double Capacity = double.Parse(textBox3.Text);
            double Thickness = double.Parse(textBox4.Text);

            double AreaPowerToo = double.Parse(textBox6.Text);
            double SpacePowerToo = double.Parse(textBox7.Text);
            double CapacityPowerToo = double.Parse(textBox8.Text);
            double ThicknessPowerToo = double.Parse(textBox9.Text);

            

            //double Area = 1.04;
            //double Space = 4.2;
            //double Capacity = 30;
            //double Thickness = 1.475;

            //double AreaPowerToo = -2;
            //double SpacePowerToo = -3;
            //double CapacityPowerToo = -12;
            //double ThicknessPowerToo = -3;

            Capacity = Capacity * Math.Pow(10, CapacityPowerToo);
            Space = Space * Math.Pow(10, SpacePowerToo);
            Area = Area * Math.Pow(10, AreaPowerToo);
            Thickness = Thickness * Math.Pow(10, ThicknessPowerToo);

            textBox5.Text = Calculate(Capacity, Space, Area, Thickness).ToString();
            Check(Calculate(Capacity, Space, Area, Thickness));
        }
        
        public double Calculate ( double c , double s , double a , double t)
        {
            
            return (c * t) / (8.85 * Math.Pow(10, -12) * a - c * (s - t));
        }
        public void Check (double x)
        {
            comboBox1.Items.Clear();
            if (x >= 1 && x <= 1.01)
            {
                comboBox1.Items.Add("Oras");
            }
            if (x >= 2.5 && x <= 4)
            {
                comboBox1.Items.Add("Organinis stiklas");
            }
            if (x >= 2.5 && x <= 6)
            {
                comboBox1.Items.Add("Getinaksas");
            }
            if (x >= 3.1 && x <= 4)
            {
                comboBox1.Items.Add("Polichlorvinilas");
            }
            if (x >= 4 && x <= 15)
            {
                comboBox1.Items.Add("Stiklas");
            }
            if (x >= 2 && x <= 3)
            {
                comboBox1.Items.Add("Polichlorvinilas");
            }

            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.SelectedIndex = 0;
            }
         

        }
    }
}
