using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 5);
            Console.WriteLine("Try and guess my number!");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("lucky guess");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high. Try again");
            }
            else 
            {
                Console.WriteLine("Too low. Try again");
            }
            

            Console.WriteLine("what is your favorie subject in school?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "mathmatics":
                case "math":
                    Console.WriteLine("ugh math");
                    break;
                case "gym":
                    Console.WriteLine("heck yeah basketball");
                    break;
                case "english":
                    Console.WriteLine("i hate essays");
                    break;
                case "biolgy":
                    Console.WriteLine("study of life!");
                    break;
                case "lunch":
                    Console.WriteLine("my favorite!");
                        break;
                default:
                    Console.WriteLine("i don't know what you are studing");
                    break;





            }  
                
        }
    }
}
