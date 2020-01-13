using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks
{
    class Program
    {
       
          

       
       





        static void Main(string[] args)
        {
            /*  Console.WriteLine("Ievadiet zekju skaitu");
              int socksCount = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Ievadiet zekju krasu skaitu");
              int socksColorCount = Convert.ToInt32(Console.ReadLine());

              Random rnd = new Random();    

              int[] array = new int[socksCount];
              int[] array2 = new int[socksCount];


                  for (int i = 0; i < socksCount; i++)
            {
               int socskColor = rnd.Next(1, socksColorCount + 1);
                array[i] = socskColor;
                array2[i] = array[i]; 
            }

  */
            int socksCount = 7;
         // int socksColorCount = 3;

            int[] array =  { 5, 2, 3, 5, 5, 2, 5};
            Array.Sort(array);
            for (int i = 0; i < socksCount; i++)
            {
                Console.Write(array[i] + " ");
            }

            Array.Sort(array);
            int count = 0;
            

            for (int i = 0; i < socksCount-1; i++)
            {


                if (array[i] == array[i + 1])
                {

                    count++;
                    i++;


                }
      

                
                
            }

            Console.WriteLine();
            
            Console.WriteLine(count);


            Console.Read();
        }
    }
}
