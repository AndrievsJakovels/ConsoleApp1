using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gramatas_jauns
{
    class GramatuParvaldnieks
    {
        public List<Gramata> Gramatas;

        public GramatuParvaldnieks()
        {

            Gramatas = new List<Gramata>();
            Gramatas.Add(new Gramata() { Nosaukums = "Moby Dick", Skaits = 2 });
            Gramatas.Add(new Gramata() { Nosaukums = "The Iliad", Skaits = 3 });
        }


        public Gramata PanemtGramatu(string nosaukums)
        {
            Gramata gramata = null;
            foreach (Gramata g in Gramatas)
            {
                if (g.Nosaukums.Equals(nosaukums))
                {
                    gramata = g;
                    break;
                }
                if (gramata == null)

                {

                    // nav atrasta
                    Console.WriteLine("Gramata nav atrasta");

                }
                else
                {

                    // ir atrasta
                    if (gramata.Skaits == 0)
                    {
                        Console.WriteLine("Si gramata vairak nav pieejama");
                    }
                    else
                    {

                        gramata.Skaits--;
                        SarakstaIzvade();
                        return gramata;


                    }
                }

            }
            return null;

        }
        public void AtgrieztGramatu(string nosaukums)
        {
            Gramata gramata = null;
            foreach (Gramata g in Gramatas)
            {
                if (g.Nosaukums.Equals(nosaukums))
                {
                    gramata.Skaits++;
                }
                else {
                    Gramatas.Add (new Gramata(){
                        Nosaukums = nosaukums,
                        Skaits = 1,

                    });
                }

            }


        }
        public void SarakstaIzvade()
        {
            foreach (var gramata in Gramatas) {
                Console.WriteLine(gramata.Nosaukums, gramata.Skaits);
            }

        }


    }
}
