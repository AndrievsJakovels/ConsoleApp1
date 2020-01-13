using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeleUzminiSkaitli
{
    public partial class Form1 : Form
    {
        int minejums;
        public Form1()
        {
            InitializeComponent();
          
        }

      
            static Random rnd = new Random();
            int atbilde = rnd.Next(1, 1001);
        
         


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            minejums = Convert.ToInt32(textBox1.Text);
        }

        public void ButtonMinet_Click(object sender, EventArgs e)
        {
            if (minejums == atbilde)
            {
                label3.Text = "Uzminets";

            }
            else if (minejums > atbilde)
            {
                label3.Text = "Megini mazaku skaitli";
            }
            else
            {
                label3.Text = "Megini lielaku skaitli";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            


        }
    }
}
