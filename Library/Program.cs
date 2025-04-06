namespace Library
{
    public class Library
    {
        public static void Main(string[] args)
        {
            User UserOne = new() { Id = 1, Name = "Matteo", Surname = "Pini", SubscriptionDate = "03/02/2024" };
            Console.WriteLine(UserOne.Denomination);

            User UserTwo = new() { Id = 2, Name = "Giorgio", Surname = "Gozzi", SubscriptionDate = "07/02/2024" };
            Console.WriteLine(UserTwo.Denomination);

            Book BookOne = new(1, "Eragon", "Paolini");

            BookOne.Loan(UserOne);
            Console.WriteLine(BookOne.Description());
            BookOne.Loan(UserTwo);

            BookOne.Return();
            BookOne.Loan(UserTwo);
        }
    }

    public class Person()
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Denomination
        {
            get
            {
                return $"User {Name} {Surname}";
            }
        }
    }
    public class User : Person
    {
        public int Id { get; set; }

        public string? SubscriptionDate { get; set; }

        public new string? Denomination
        {
            get
            {
                return $"User n{Id}: {Name} {Surname}, since {SubscriptionDate}";
            }
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
                Console.WriteLine($"The book is already borrowed by {User.Denomination}");
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
                Console.WriteLine($"{User.Denomination} has returend the book");
                User = null;
            }
        }
    }
}