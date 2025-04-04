using System; 

namespace IntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            short b = 100;
            sbyte c = -50;
            long d = 1_000_000L;
            int e = 0b10101010;
            ushort f = 0x0A56;

            Console.WriteLine("Ho un int: {0} e un long: {1}", a, d);
            Console.WriteLine($"Ho uno short: {b}, un int binario: {e}, un sbyte: {c} e uno short esadecimale: {f}");
        }
    }
}