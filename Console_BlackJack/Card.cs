using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_BlackJack
{

    class Card
    {
        public string masts, rangs;
        public int Id;


        public Card(string masts, string rangs)
        {
            this.masts = masts;
            this.rangs = rangs;
            
        }

        public void Deck()
        {

           
            List<Card> kartis = new List<Card>();

           // for (int i = 0; i < 4; i++)   // masti
           // {
                for (int j = 0; j < 13; j++) //  rangi
                {
                    kartis.Add(new Card("karavs", "1111"));
                Console.WriteLine(kartis[j]);

                   // if (j <= 8)
                  //      kartis[kartis.Count - 1].Value = j + 1;
                 //   else
                   //     kartis[kartis.Count - 1].Value = 10;
                }
           // }







        }


    }
}
