using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double skaitlis1, skaitlis2, rezultats;

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            skaitlis2 = Convert.ToDouble(textBox2.Text);
        }

        private void ButtonMius_Click(object sender, EventArgs e)
        {
            double rezultats = skaitlis1 - skaitlis2;
            textBox3.Text = rezultats.ToString();
        }

        private void ButtonMultiplay_Click(object sender, EventArgs e)
        {
            double rezultats = skaitlis1 * skaitlis2;
            textBox3.Text = rezultats.ToString();
        }

        private void ButtonAvg_Click(object sender, EventArgs e)
        {
            double rezultats = (skaitlis1 + skaitlis2)/2;
            textBox3.Text = rezultats.ToString();
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            if (skaitlis1 > skaitlis2)
            {
                textBox3.Text = skaitlis2.ToString();


            }
            else
            {
                textBox3.Text = skaitlis1.ToString();
            }

                 }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            if (skaitlis1 > skaitlis2)
            {
                textBox3.Text = skaitlis1.ToString();


            }
            else
            {
                textBox3.Text = skaitlis2.ToString();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            skaitlis1 = Convert.ToDouble(textBox1.Text);
           


        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            double rezultats = skaitlis1 + skaitlis2;
            textBox3.Text = rezultats.ToString();
        }
    }
}
