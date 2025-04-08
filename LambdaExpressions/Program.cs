namespace LambdaExpressions
{
    public class Program
    {

        private string name = "";

        public string Name
        {
            get => char.ToUpper(name[0]) + name[1..];

            set => name = value;
        }

        public Program(string name) => this.name = name;

        static void Main(string[] args)
        {
            Program n = new("matteo");
            Console.WriteLine(n.Name);
        }
    }
}