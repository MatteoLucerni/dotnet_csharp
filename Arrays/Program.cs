namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[5, 5];

            int incrementer = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    x[j, i] = j != 0 ? j + incrementer : 0;

                    Console.Write(x[j, i] + " ");
                }

                incrementer += 5;
                Console.WriteLine();
            }
        }
    }
}