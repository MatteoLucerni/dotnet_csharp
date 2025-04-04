using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Numero righe: ");
                var s = Console.ReadLine();

                if (s == "no") break;

                int n = Convert.ToInt32(s);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}