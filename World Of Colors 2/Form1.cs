using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Of_Colors_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form3 woc = new Form3();
                woc.Show();
                this.Hide();
                MessageBox.Show("Welcome :)");
          
             }
            else
            {
                MessageBox.Show("Your username or password is incorrect");
                textBox1.Clear();
                textBox2.Clear(); 
            }

            

        }
    }
}
