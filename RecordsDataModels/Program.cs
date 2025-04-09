using RecordsDataModels;

// class check (ref type, semanthic by reference)
Book book1 = new("The Great Gatsby", "F. Scott Fitzgerald");
Book book2 = new("To Kill a Mockingbird", "Harper Lee");
Book book3 = new("To Kill a Mockingbird", "Harper Lee");
Book book4 = book1;

Console.WriteLine(book1 == book2);
Console.WriteLine(book1);
Console.WriteLine(book3 == book2);
Console.WriteLine(book4 == book1);

Console.WriteLine("-----");

// record check (ref type, semanthic by value)
BookData bookData1 = new("The Great Gatsby", "F. Scott Fitzgerald");
BookData bookData2 = new("To Kill a Mockingbird", "Harper Lee");
BookData bookData3 = new("To Kill a Mockingbird", "Harper Lee");
BookData bookData4 = bookData1;

Console.WriteLine(bookData1 == bookData2);
Console.WriteLine(bookData1);
Console.WriteLine(bookData3 == bookData2);
Console.WriteLine(bookData4 == bookData1);

Console.WriteLine("-----");

// record check (bref type, semanthic by value, short form)
ShortBookData shortBookData1 = new("The Great Gatsby", "F. Scott Fitzgerald");
ShortBookData shortBookData2 = new("To Kill a Mockingbird", "Harper Lee");
ShortBookData shortBookData3 = new("To Kill a Mockingbird", "Harper Lee");
ShortBookData shortBookData4 = shortBookData1;

Console.WriteLine(shortBookData1 == shortBookData2);
Console.WriteLine(shortBookData1);
Console.WriteLine(shortBookData3 == shortBookData2);
Console.WriteLine(shortBookData4 == shortBookData1);

// Non destructive copy
ShortBookData shortBookData5 = shortBookData1 with { Title = "Il grande Gatsby (ITA)" };
Console.WriteLine(shortBookData1);
Console.WriteLine(shortBookData5);
Console.WriteLine(shortBookData5 == shortBookData1);

// inheritance
ShortBookDataDigital shortBookDataDigital1 = new("The Great Gatsby", "F. Scott Fitzgerald", 200);
Console.WriteLine(shortBookDataDigital1);

namespace RecordsDataModels
{
    public class Book
    {
        public string Title { get; init; } = "";
        public string Author { get; init; } = "";

        public Book() { }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

    }

    public record BookData
    {
        public string Title { get; init; } = "";
        public string Author { get; init; } = "";

        public BookData() { }

        public BookData(string title, string author)
        {
            Title = title;
            Author = author;
        }

    }

    public record ShortBookData(string Title, string Author);

    public record ShortBookDataDigital(string Title, string Author, int Minutes) : ShortBookData(Title, Author);

}