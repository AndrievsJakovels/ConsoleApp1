using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desas2
{
    public partial class Form1 : Form
    {
        bool gajiens = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (gajiens == true)
            {
                a.Text = "X";
                label1.Text = "2. speletaja gajiens";
            }
            else
            {


                a.Text = "O";
                label1.Text = "1. speletaja gajiens";
            }
            gajiens = !gajiens;

            a.Enabled = false;

         

            uzvaretajs();

        }

        private void uzvaretajs()
        {

            bool uzvara = false;
          


            if (button11.Text != "" && button11.Text == button12.Text && button12.Text == button13.Text)
            {
                uzvara = true;
            }
            else if (button21.Text != "" && button21.Text == button22.Text && button22.Text == button23.Text)
            {
                uzvara = true;

            }
            else if (button31.Text != "" && button31.Text == button32.Text && button32.Text == button33.Text)
            {
                uzvara = true;
            }
            else if (button11.Text != "" && button11.Text == button12.Text && button12.Text == button22.Text)
            {
                uzvara = true;
            }
            else if (button21.Text != "" && button21.Text == button22.Text && button22.Text == button23.Text)
            {
                uzvara = true;
            }
            else if (button31.Text != "" && button31.Text == button32.Text && button32.Text == button33.Text)
            {
                uzvara = true;
            }
            else if (button11.Text != "" && button11.Text == button22.Text && button22.Text == button33.Text)
            {
                uzvara = true;
            }
            else if (button31.Text != "" && button31.Text == button22.Text && button22.Text == button13.Text)
            {
                uzvara = true;
            }

            if (uzvara == true)
            {
                if (gajiens)
                {
                    MessageBox.Show("uzvar 2.speletajs");
                }
                else
                {
                    MessageBox.Show("uzvar 1.speletajs");
                }

            }
            


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
