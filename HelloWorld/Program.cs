// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworldMessage = "Hello World!!!";

            Console.WriteLine(HelloWorld(helloworldMessage));
        }

        private static string HelloWorld(string message)
        {
            // Esta linea es para prueba 
            return message + " Welcome to my console app";
        }
    }
}
