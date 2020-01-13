using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurtiE
{
    public partial class Form1 : Form
    {
        string vards, rez;
        int rezultats = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            vards = textBox1.Text;
           


        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            rezultats = 0;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            char[] charArray = vards.ToCharArray();
            for (int i = 0; i < vards.Length ; i++)
            {
                if (vards[i] == 'e')
                {
                    rezultats++;
                }
            }
            string rez = Convert.ToString(rezultats);
            textBox2.Text = rez;
        }
       // rez = vards.Count(burts => burts == 'e' ||)burts == 'E');
    }
}
