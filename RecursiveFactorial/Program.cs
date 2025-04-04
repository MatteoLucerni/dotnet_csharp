using System.Security.Cryptography.X509Certificates;

namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}