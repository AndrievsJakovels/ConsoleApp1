using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedejie2skaitli
{
    public partial class Form1 : Form
    {
        string  skaitlis1pedejie2, skaitlis2pedejie2;
        int skaitlis1, skaitlis2;

        private void ButtonCheck_Click(object sender, EventArgs e)
        {

            if (skaitlis1 < 10)
            {
                MessageBox.Show("Ievadiet skaitli 1 ar diviem cipariem");

            }
            else if (skaitlis2 < 10 )
            {
                MessageBox.Show("Ievadiet skaitli 2 ar diviem cipariem");

            }
            else
            {
                string sk1 = skaitlis1.ToString();
                string sk2 = skaitlis2.ToString();

                skaitlis1pedejie2 = sk1.Substring(sk1.Length - 2);
                skaitlis2pedejie2 = sk2.Substring(sk2.Length - 2);

                textBoxNumerOneLAst2.Text = skaitlis1pedejie2;
                textBoxNumerTwoLAst2.Text = skaitlis2pedejie2;

                if (skaitlis1pedejie2 == skaitlis2pedejie2)
                {
                    MessageBox.Show("Skaitļa 1 un skaitļa 2 pēdējie 2 cipari ir vienadi");
                }
                else
                {
                    MessageBox.Show("Skaitļa 1 un skaitļa 2 pēdējie 2 cipari nav vienadi");
                }

            }


        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBoxNumerOneLAst2.Text = String.Empty;
            textBoxNumerTwoLAst2.Text = String.Empty;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
                skaitlis2 = Convert.ToInt32(textBox2.Text);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
                skaitlis1 = Convert.ToInt32(textBox1.Text);
        }
    }
}
