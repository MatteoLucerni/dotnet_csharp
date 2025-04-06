namespace Library
{
    public class Library
    {
        public static void Main(string[] args)
        {
            User UserOne = new(1, "Matteo", "Pini", "03/02/2024");
            Console.WriteLine(UserOne.Denomination());
            
            User UserTwo = new(2, "Giorgio", "Gozzi", "15/07/2025");
            Console.WriteLine(UserTwo.Denomination());

            Book BookOne = new(1, "Eragon", "Paolini");

            BookOne.Loan(UserOne);
            Console.WriteLine(BookOne.Description());
            BookOne.Loan(UserTwo);

            BookOne.Return();
            BookOne.Loan(UserTwo);
        }
    }
    public class User(int id, string name, string surname, string subscriptionDate)
    {
        private readonly int id = id;
        private readonly string name = name;
        private readonly string surname = surname;
        private readonly string subscriptionDate = subscriptionDate;

        public string Denomination()
        {
            return $"User n{id}: {name} {surname}, since {subscriptionDate}";
        }
    }

    public class Book(int id, string title, string author)
    {
        private readonly int id = id;
        private readonly string title = title;
        private readonly string author = author;
        private User? User = null;

        public string Description()
        {
            return $"Book {id}: {title} by {author}";
        }

        public void Loan(User borrowingUser)
        {
            if (User == null)
            {
                User = borrowingUser;
            }
            else
            {
                Console.WriteLine($"The book is already borrowed by {User.Denomination()}");
            }
        }

        public void Return()
        {
            if (User == null)
            {
                Console.WriteLine("No need to return this book");
            }
            else
            {
                Console.WriteLine($"{User.Denomination()} has returend the book");
                User = null;
            }
        }
    }
}