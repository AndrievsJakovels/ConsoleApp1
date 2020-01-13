using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GramatuKatalogs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gramatas = new List<string>();
            gramatas.Add("Pasakas");
            gramatas.Add("Dzeja");
            gramatas.Add("Eposs");
            gramatas.Add("Makslas Literatura");

            List<int> skaits = new List<int>();
            skaits.Add(1);
            skaits.Add(4);
            skaits.Add(3);
            skaits.Add(2);


            while (true)
            {
                Console.WriteLine("Biblioteka pieejams: \n");

                for (int i = 0; i <= gramatas.Count - 1; i++) 
                {
                    Console.WriteLine("{0}  {1} eksemplari", gramatas[i], skaits[i]);

                }

                Console.WriteLine("Ievadiet darbibu - iznemt gramatu / atgriezt gramatu");
                string darbiba = Console.ReadLine();
                Console.WriteLine("Ievadiet gramatas nosaukumu");
                string gramataKuruVelas = Console.ReadLine();

                for (int i = 0; i <= gramatas.Count - 1; i++)
                {
                    if (darbiba == "iznemt gramatu")
                    {
                        if (gramatas[i] == gramataKuruVelas)
                        {
                            if (skaits[i] > 0)
                            {
                                skaits[i] -= 1;
                            }
                            else
                            {
                            Console.WriteLine("Gramata nav pieejama");

                            }


                        }

                       
                    }


                }
                int skaitlis=0;
                for (int i = 0; i <= gramatas.Count - 1; i++)
                {
                    if (darbiba == "atgriezt gramatu")
                    {
                        if (gramatas[i] == gramataKuruVelas)
                        {
                            skaits[i] += 1;

                        }
                        else {
                            skaitlis++;
                        }

                    }

                }

                if (skaitlis == gramatas.Count )
                {
                    gramatas.Add(gramataKuruVelas);
                    skaits.Add(1);


                }


            }
            
        }
    }
}


  
                   