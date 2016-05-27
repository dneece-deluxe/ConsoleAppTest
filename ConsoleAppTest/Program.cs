using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // dispaly some text
            
            PrintIt(
                "Howdy!");

            Console.Read();// hold open to see it
        }

        static void PrintIt(string message)
        {
            if(!string.IsNullOrWhiteSpace(message))
                Console.WriteLine(
                    message);
        }
    }
}