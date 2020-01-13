using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trisvardid();
            Console.ReadLine();
        }
        static void Trisvardid()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Ievadiet skaitli1:_");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet skaitli2:_");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet skaitli3:_");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Pirmais irpats lielakais");

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Otrais cirpats lielakais");

            }
            else if (num3 > num1 && num3 > num1)
            {
                Console.WriteLine("Tresais cirpats lielakais");

            }
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("Pirmais irpats mazakais");

            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("Otrais cirpats mazakais");

            }
            else if (num3 < num1 && num3 < num1)
            {
                Console.WriteLine("Otrais cirpats mazakais");

            }

            // int min = sk1<sk2? : sk1:sk2; shorthand if
            // int min3 = Math.Min(Math.Min(sk1, sk2), sk3);



        }

    }
}
