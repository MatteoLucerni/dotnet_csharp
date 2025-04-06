namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new()
            {
                MyInt = 34,
                MyString = "Wow che classe!"
            };

            MyStruct ms = new()
            {
                MyInt = 34,
                MyString = "Buono lo strutto!"
            };

            Console.WriteLine($"Class: {mc.MyInt} -> {mc.MyString}");
            Console.WriteLine($"Struct: {ms.MyInt} -> {ms.MyString}");

            ClassMethod(mc, ms, 111, "Sovrascritto");

            Console.WriteLine($"Class: {mc.MyInt} -> {mc.MyString}");
            Console.WriteLine($"Struct: {ms.MyInt} -> {ms.MyString}");
        }

        public static void ClassMethod(MyClass Class1, MyStruct Struct1, int int1, string str1)
        {
            Class1.MyInt = int1;
            Struct1.MyInt = int1;

            Class1.MyString = str1;
            Struct1.MyString = str1;
        }
    }

    public class MyClass
    {
        public string? MyString;
        public int MyInt;
    }

    public struct MyStruct
    {
        public string? MyString;
        public int MyInt;
    }
}