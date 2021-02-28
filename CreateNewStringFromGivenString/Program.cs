using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CreateNewStringFromGivenString
{
    class Program
    {
        //Write a C# program to create a new string from a given string
        //(length 1 or more ) with the first character added at the front and back.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence : ");
            string words = Console.ReadLine();

            NewSentence(words);

        }

        static string NewSentence(string words)
        {
            if (words.Length > 1)
            {
                string s = words.Substring(0, 1);
                Console.WriteLine(s + words + s);

            }

            return (words);
        }
    }
}
