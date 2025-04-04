// See https://aka.ms/new-console-template for more information

int x = 120_320_120;
char c = '!';
string s = "Hello, World";

// no new line at the end
Console.Write(s + c + ' ' + x);

// new line
Console.WriteLine(s + c + ' ' + x);

// interpolation with placeholders
Console.WriteLine("{0}{1}", s, c);

// interpolation without placeholders
Console.WriteLine($"{s}{c}");
