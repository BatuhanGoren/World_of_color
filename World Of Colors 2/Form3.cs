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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Blue")
            {
                label3.Text = textBox1.Text + "," + comboBox1.Text +" "+"is" +" "+"Symbolizes cuteness and harmony, cheers and relaxes people.";
                button1.BackgroundImage = null;
                button1.BackColor = Color.Blue;
                

            }
            if (comboBox1.Text == "Black")
            {
                label3.Text = textBox1.Text + "," + comboBox1.Text + " " + "is" + " " + " Symbolizes strength, self-confidence, discipline and might.";
                button1.BackgroundImage = null;
                button1.BackColor = Color.Black;
            }
            if (comboBox1.Text=="White")
            {
                label3.Text = textBox1.Text + "," + comboBox1.Text + " " + "is" + " " + " Represents cold-bloodedness, nobility, innocence, stability and continuity. It gives peace and confidence.";
                button1.BackgroundImage = null;
                button1.BackColor = Color.White;
            }
            if (comboBox1.Text=="Green")
            {
                label3.Text = textBox1.Text + "," + comboBox1.Text + " " + "is" + " " + " Represents harmony and balance.";
                button1.BackgroundImage = null;
                button1.BackColor = Color.Green;
            }
            if (comboBox1.Text=="Red")
            {
                label3.Text = textBox1.Text + "," + comboBox1.Text + " " + "is" + " " + " Represents happiness and stimulates appetite.";
                button1.BackgroundImage = null;
                button1.BackColor = Color.Red;

            }
            if (comboBox1.Text=="Yellow")
            {
                label3.Text = textBox1.Text + "," + comboBox1.Text + " " + "is" + " " + " Symbolizes existence, life, intelligence, desires and spiritual development. ";
                button1.BackgroundImage = null;
                button1.BackColor = Color.Yellow;
            }
        }
    }
}
