using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input number of steps n");
            int n = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input path ");
            //     string path = Console.ReadLine();
          //  string path2 = "UUDDDUDDUUU";
            string path = "DUDUUUDD";
            char[] pathCharrArray = path.ToCharArray();
            int[] array = new int[n];
            int startPosition = 1000;
   
            int count = 0;
            int valleyCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (pathCharrArray[i] == 'U')
                {

                    startPosition +=1;
                    array[i] = startPosition;


                    if (startPosition == 1000 )
                  {
                        count++;
                  }

                }
                else
                {

                    startPosition -= 1;

                    array[i] = startPosition;

                    if (startPosition == 1000)
                    {
                        count++;
                    }

                }



            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);

                if (array[i] == 999 && array[i+1] == 1000)
                {
                    valleyCount++;
                }
            }
                Console.WriteLine(valleyCount);
         //   Console.WriteLine(count-1);
            Console.ReadKey();


        }
    }
}
