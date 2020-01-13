using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EURtoUSD
{
    public partial class Form1 : Form
    {

        double skaitlis1, skaitlis2;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            skaitlis2 = Convert.ToDouble(textBox2.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            skaitlis2 = skaitlis1 * 1.128;
            textBox2.Text = skaitlis2.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            skaitlis1 = skaitlis2 * 0.88;
            textBox1.Text = skaitlis1.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            skaitlis1 = Convert.ToDouble(textBox1.Text);
        }
    }
}
