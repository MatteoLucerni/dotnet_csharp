using System;

namespace Conditions{
    class Program{
        static void Main(string[] args){

            Console.Write("Parola: ");
            var s = Console.ReadLine();

            switch(s){
                case "primo": {
                    Console.WriteLine("Hai scritto primo!");
                    break;
                }
                case "secondo": {
                    Console.WriteLine("Hai scritto secondo!");
                    break;
                }
                default: {
                    Console.WriteLine("Hai scritto: " + s);
                    break;
                }
            }
        }
    }
}