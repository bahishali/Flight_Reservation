using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route: " + comboBox1.Text + " - " + comboBox2.Text + "  Date: " + dateTimePicker1.Text + "  Time: " + maskedTextBox1.Text+" Passenger Info // Name: "+ textBox1.Text+" TC: "+ maskedTextBox2.Text+" Phone: "+maskedTextBox3.Text);
            MessageBox.Show("Passenger has been registered.");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
