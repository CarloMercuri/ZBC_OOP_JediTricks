using System;
using System.Collections.Generic;
using System.Threading;

namespace ZBC_OOP_JediTricks
{
    class Program
    {
        static void Main(string[] args)
        {

            int sleepAmount = 400;

            // Create the dictionary
            Dictionary<string, int> people = new Dictionary<string, int>();

            Console.WriteLine("Created new dictionary!\n\r");

            Thread.Sleep(sleepAmount);

            // Opg2, add
            people.Add("Carlo Mercuri", 36);

            Console.WriteLine("Added Carlo Mercuri of age 36 with Add.\n\r");
            Thread.Sleep(sleepAmount);

            // Opg2, indeksnotation
            people["Tanja Mercuri"] = 39;

            Console.WriteLine("Added Tanja Mercuri of age 36 with Index\n\r");
            Thread.Sleep(sleepAmount);

            // Opg2, print first
            Console.WriteLine($"First person is Carlo Mercuri, age: {people["Carlo Mercuri"]}\n\r");
            Thread.Sleep(sleepAmount);

            // Opg3

            Dictionary<string, bool> characters = new Dictionary<string, bool>() 
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            characters.Remove("Han");

            Console.WriteLine("Removed Han from the new dictionary\n\r");

            Thread.Sleep(sleepAmount);

            Console.WriteLine("Who is a jedi now?\n\r");

            Thread.Sleep(sleepAmount);

            foreach(var kvPair in characters)
            {
                if (kvPair.Value)
                {
                    Console.WriteLine($"{kvPair.Key} is a jedi!");
                } else
                {
                    Console.WriteLine($"{kvPair.Key} is NOT a jedi!");
                }
            }

                Console.ReadLine();
        }
    }
}
