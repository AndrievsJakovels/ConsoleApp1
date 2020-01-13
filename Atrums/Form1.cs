using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atrums
{
    public partial class Form1 : Form
    {

        double metri, minutes, sekundes, atrums, stundas, km, atrums2, miles;

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxSeconds.Text = "";
            textBoxSpeedms.Text =  "";
            textBoxSpeedhmh.Text = "";
            textBoxDistancekm.Text = "";
            textBox7.Text = "";
            textBoxMinutes.Text = String.Empty;
            textBoxMeters.Text = String.Empty;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBoxSeconds_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            sekundes = minutes * 60;
            textBoxSeconds.Text = sekundes.ToString();
            atrums = metri / sekundes;
            textBoxSpeedms.Text = atrums.ToString();
            stundas = minutes / 60;
            km = metri / 1000;
            atrums2 = km / stundas;
            textBoxSpeedhmh.Text = atrums2.ToString();
            textBoxDistancekm.Text = km.ToString();
            miles = km * 0.621;
            textBox7.Text = miles.ToString();


        }

        private void TextBoxMinutes_TextChanged(object sender, EventArgs e)
        {

            if (textBoxMinutes.Text != String.Empty)
                minutes = Convert.ToDouble(textBoxMinutes.Text);
        }

        private void TextBoxMeters_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMeters.Text != String.Empty)
                metri = Convert.ToDouble(textBoxMeters.Text);

        }
    }
}
