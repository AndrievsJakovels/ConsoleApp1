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
        bool datorspele = false;
        

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
            neizskirts();
            if (datorspele == true)
            { 
                     if (!gajiens)
                {
                datoraGajiens();

            }
           

         

            
            }
            
            uzvaretajs();

        }

        private void uzvaretajs()
        {

            bool uzvara = false;
          

            // parbauda horizontali
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
            // parbauda vertikali
            if (button11.Text != "" && button11.Text == button21.Text && button21.Text == button31.Text)
            {
                uzvara = true;
            }
            else if (button12.Text != "" && button12.Text == button22.Text && button22.Text == button32.Text)
            {
                uzvara = true;

            }
            else if (button31.Text != "" && button31.Text == button32.Text && button32.Text == button33.Text)
            {
                uzvara = true;
            }




            // parbauda diaognales
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
                    
                        Clear();
                    
                }
                else
                {
                    MessageBox.Show("uzvar 1.speletajs");
                    
                    
                        Clear();
                    
                }

            }
            


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clear();
            
            datorspele = false;
        }

        public void Clear()
        {
            button11.Text = "";
            button11.Enabled = true;
            button12.Text = "";
            button12.Enabled = true;
            button13.Text = "";
            button13.Enabled = true;
            button21.Text = "";
            button21.Enabled = true;
            button22.Text = "";
            button22.Enabled = true;
            button23.Text = "";
            button23.Enabled = true;
            button31.Text = "";
            button31.Enabled = true;
            button32.Text = "";
            button32.Enabled = true;
            button33.Text = "";
            button33.Enabled = true;
            gajiens = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void datoraGajiens()
        {
            Button b = null;
            b = vidus();
            
            if (b == null) { 
            b = diviPecKartas("O");
                     
            if (b == null)
            {
              b = diviPecKartas("X");
                   
                    if (b == null)
               {
                    b = mekleBrivuSturi();
                       
                        if (b == null)
                    {
                    b = randomVieta();
                          
                        }
               }

            }
            }
            b.PerformClick();

        }

        private Button diviPecKartas(string zime)
        {
            // horizotnali 1 rinda
            if ((button11.Text == zime) && (button12.Text == zime) && (button13.Text == ""))
            {
                return button13;
            }
            if ((button11.Text == zime) && (button12.Text == "") && (button13.Text == zime))
            {
                return button12;
            }
            if ((button11.Text == "") && (button12.Text == zime) && (button13.Text == zime))
            {
                return button11;
            }
            // horizotnali 2 rinda
            if ((button21.Text == zime) && (button22.Text == zime) && (button23.Text == ""))
            {
                return button23;
            }
            if ((button21.Text == zime) && (button22.Text == "") && (button23.Text == zime))
            {
                return button22;
            }
            if ((button21.Text == "") && (button22.Text == zime) && (button23.Text == zime))
            {
                return button21;
            }
            // horizotnali 3 rinda
            if ((button31.Text == zime) && (button32.Text == zime) && (button33.Text == ""))
            {
                return button33;
            }
            if ((button31.Text == zime) && (button32.Text == "") && (button33.Text == zime))
            {
                return button32;
            }
            if ((button31.Text == "") && (button32.Text == zime) && (button33.Text == zime))
            {
                return button31;
            }
            // vertikali 1 kollona
            if ((button11.Text == zime) && (button21.Text == zime) && (button31.Text == ""))
            {
                return button31;
            }
            if ((button11.Text == zime) && (button21.Text == "") && (button31.Text == zime))
            {
                return button21;
            }
            if ((button11.Text == "") && (button21.Text == zime) && (button31.Text == zime))
            {
                return button11;
            }
            // vertikali 2 kollona
            if ((button12.Text == zime) && (button22.Text == zime) && (button32.Text == ""))
            {
                return button32;
            }
            if ((button12.Text == zime) && (button22.Text == "") && (button32.Text == zime))
            {
                return button22;
            }
            if ((button12.Text == "") && (button22.Text == zime) && (button32.Text == zime))
            {
                return button12;
            }
            // vertikali 3 kollona
            if ((button13.Text == zime) && (button23.Text == zime) && (button33.Text == ""))
            {
                return button33;
            }
            if ((button13.Text == zime) && (button23.Text == "") && (button33.Text == zime))
            {
                return button23;
            }
            if ((button13.Text == "") && (button23.Text == zime) && (button33.Text == zime))
            {
                return button13;
            }
            // diagonāle 11 uz 33
            if ((button11.Text == zime) && (button22.Text == zime) && (button33.Text == ""))
            {
                return button33;
            }
            if ((button11.Text == zime) && (button22.Text == "") && (button33.Text == zime))
            {
                return button22;
            }
            if ((button11.Text == "") && (button22.Text == zime) && (button33.Text == zime))
            {
                return button11;
            }
            // diagonāle 13 uz 31
            if ((button13.Text == zime) && (button22.Text == zime) && (button31.Text == ""))
            {
                return button31;
            }
            if ((button13.Text == zime) && (button22.Text == "") && (button31.Text == zime))
            {
                return button22;
            }
            if ((button13.Text == "") && (button22.Text == zime) && (button31.Text == zime))
            {
                return button13;
            }

            return null;
        }
        private Button vidus()
        {
            if (button22.Text == "") {
                return button22;
            }
            return null;
        }
        private void neizskirts()
        {
            int parbaude = 0;
            if ((button11.Text != "") && (button12.Text != "") && (button13.Text != "")) 
            {
                parbaude++;
            }
            if ((button21.Text != "") && (button22.Text != "") && (button23.Text != ""))
            {
                parbaude++;
            }
            if ((button31.Text != "") && (button32.Text != "") && (button33.Text != ""))
            {
                parbaude++;
            }

            if (parbaude == 3)
            {
                MessageBox.Show("Spele ir neizskjirta!");
                Clear();
            }

        }
        
        private Button mekleBrivuSturi()
        {
            if (button11.Text == "O")
            {               
                if (button13.Text == "")
                    return button13;
                if (button31.Text == "")
                    return button31;
                if(button33.Text == "")
                    return button33;
            }
            if (button13.Text == "O")
            {
                if (button11.Text == "")
                    return button11;
                if (button31.Text == "")
                    return button31;
                if (button33.Text == "")
                    return button33;
            }
            if (button31.Text == "O")
            {
                if (button13.Text == "")
                    return button13;
                if (button11.Text == "")
                    return button11;
                if (button33.Text == "")
                    return button33;
            }
            if (button33.Text == "O")
            {
                if (button13.Text == "")
                    return button13;
                if (button31.Text == "")
                    return button31;
                if (button11.Text == "")
                    return button11;
            }
            return null;
        }

        private Button randomVieta()
        {
            bool vietaAtrasta = false;
            Random rnd = new Random();
            int pozicija = rnd.Next(1, 9);

            while (vietaAtrasta == false) { 
            
               
                switch (pozicija)
                {
                    case 1:
                        if (button11.Text == "") 
                        {
                            vietaAtrasta = true;
                            return button11;
                            
                        }
                        break;
                    case 2:
                        if (button12.Text == "") 
                        {
                            vietaAtrasta = true;
                            return button12;
                            
                        }
                        break;
                    case 3:
                        if (button13.Text == "")
                        {
                            vietaAtrasta = true;
                            return button13;
                            
                        }
                        break;
                    case 4:
                        if (button21.Text == "")
                        {
                            vietaAtrasta = true;
                            return button21;
                            
                        }
                        break;
                    case 5:
                        if (button22.Text == "")
                        {
                            return button22;
                        
                        }
                        break;
                    case 6:
                        if (button23.Text == "")
                        {
                            vietaAtrasta = true;
                            return button23;
                            
                        }
                        break;
                    case 7:
                        if (button31.Text == "")
                        {
                            vietaAtrasta = true;
                            return button31;
                        
                        }
                        break;
                    case 8:
                        if (button32.Text == "")
                        {
                            vietaAtrasta = true;
                            return button32;
                            
                        }
                        break;
                    case 9:
                        if (button33.Text == "")
                        {
                            vietaAtrasta = true;
                            return button33;
                            
                        }
                        break;
                    default: return null;
                   
                                               

                }

            }
            return null;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clear();
            datorspele = true;
                   




        }
    }
}
