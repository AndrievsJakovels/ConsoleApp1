using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LielsKalkulators
{
    public partial class Kalkulators : Form
    {
        // ieprieksievaiditais skaitlis // done
        string enterednumber = "";
        // izveleta operacija // done
        string operation = "";
        // vai ir nospiesta operacija // done
        bool isOperationClicked = false;

        public Kalkulators()
        {
            InitializeComponent();
        }

        void numberClicked(double num)
        {
            // 1. Nospiesto ciparu pievieno ievadlaukam // done
            ievadLauks.Text += num;
            
            // *ja ievadlaukā ir cipars 0, tad notira ievadlauku // done
            if (num == 0)
            {
                ievadLauks.Text = "";

            }
      

        }
        void operationClicked(string op)
        {
            // 1. Ja ' enterednumber' nav definets
            // 1.1 Šobrīd attēlotais skaitlis jāsagalabā kā 'enterednumber' // done
            // 1.2 Izveleta darbiba jasaglaba ka 'operation' 
            if (string.IsNullOrEmpty(enterednumber))
            {
                isOperationClicked = true;
                enterednumber = ievadLauks.Text;

                operation = op;
            }
            else
            {
               
                equalsClicked();
            }           

            
           

            // 2. Ja 'enteredNumber' ir definets
            // 2.1 izpilda equalsClicked()

        }
        public void equalsClicked()
        {
            // 1. Pārvērš 'entered number uz int'
        
            
            // 2. Parves ievadlauka skaitli uz int



            // 3. Aprekina rezultatu starp abiem skaitliem, izmantojot 'operation' darbibu
            // 4. Attēlo rezultātu ievadlaukā

        }
        void clearClicked()
        {
            // 1. N0tīra visu mainīgo vertibas un ievadlaukā attēloto
            isOperationClicked = false;
            enterednumber = "";
            operation = "";
            ievadLauks.Text = "";

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            numberClicked(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            numberClicked(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            numberClicked(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numberClicked(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            numberClicked(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            numberClicked(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            numberClicked(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            numberClicked(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            numberClicked(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            numberClicked(9);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            operationClicked("+");
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            operationClicked("-");
        }

        private void ButtonMuliplay_Click(object sender, EventArgs e)
        {
            operationClicked("*");
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            operationClicked("/");
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            equalsClicked();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            clearClicked();
        }

        private void IevadLauks_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
