using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gramatas_jauns
{
    class Program
    {
        static void Main(string[] args)
        {
            GramatuParvaldnieks parvaldnieks = new GramatuParvaldnieks();
            while (true) {

                Console.WriteLine("Ievadiet darbibu");
                string darbiba = Console.ReadLine();

                if (darbiba == "stop") {
                    break;
                }

                Console.WriteLine("Ievadiet gramatas nosaukumu");
                string nosaukums = Console.ReadLine();

                switch (darbiba)
                {
                    case "atgriezt" :
                        parvaldnieks.AtgrieztGramatu(nosaukums);
                        break;
                    case "panemt":
                        parvaldnieks.PanemtGramatu(nosaukums);
                        break;





                }




            }

        }
    }
}
