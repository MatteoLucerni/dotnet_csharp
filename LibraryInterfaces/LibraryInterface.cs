using System.ComponentModel;

namespace LibraryInterfaces
{
    public interface IUtente
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Denomination { get; }
    }

    public class Person(int Id, int Year, string Name, string Surname) : IUtente
    {
        public int Id { get; set; } = Id;
        public int Year { get; set; } = Year;
        public string? Name { get; set; } = Name;
        public string? Surname { get; set; } = Surname;

        public string Denomination
        {
            get
            {
                return $"User {Id}: {Name} {Surname}";
            }
        }
    }

    public class Organization(int Id, int Year, string? BusinessName) : IUtente
    {
        public int Id { get; set; } = Id;
        public int Year { get; set; } = Year;
        public string? BusinessName { get; set; } = BusinessName;

        public string Denomination
        {
            get
            {
                return $"Organization {Id}: {BusinessName}";
            }
        }
    }

    public class Library
    {
        private static IUtente[]? users;

        public static void PrintUsers()
        {
            if (users != null)
            {
                foreach (IUtente user in users)
                {
                    Console.WriteLine(user.Denomination);
                }
            }
        }

        static void Main(string[] args)
        {
            users = [
                new Person(1, 2000, "Matteo", "Ferrari"),
                new Person(2, 2001, "Gianni", "Telli"),
                new Organization(2, 1980, "Microsoft"),
                new Organization(3, 1999, "Apple"),
            ];

            PrintUsers();
        }
    }
}