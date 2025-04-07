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
            Person p1 = new(1, 2000, "Matteo", "Ferrari");
            Person p2 = new(2, 2001, "Gianni", "Telli");
            Organization o1 = new(2, 1980, "Microsoft");
            Organization o2 = new(3, 1999, "Apple");

            users = new IUtente[4];

            users[0] = p1;
            users[1] = p2;
            users[2] = o1;
            users[3] = o2;

            PrintUsers();
        }
    }
}