﻿using System;
using System.Collections.Generic;

namespace JurassicPark
{

    class Program
    {
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            //          | Name    | dietType | weight | WhenAcquired | EnclosureNumber | 
            // | ------- | -------- | ------ | ------------ | --------------- | 
            // | Ally    |carnivore | 2000  |              | 1               |
            // | Bob     |herbivore | 3000  |              | 2               | 
            // | Rock    |carnivore | 10000 |              | 3               | 
            // | Apple   |carnivore  | 5000 |              | 4               | 

            var Ally = new Dinosaur
            {
                Name = "Ally",
                DietType = "Carnivore",
                Weight = 1000,
                WhenAcquired = DateTime.Now,
                EnclosedNumber = 1,
            };

            var Bob = new Dinosaur
            {
                Name = "Bob",
                DietType = "Herbivore",
                Weight = 3000,
                WhenAcquired = "COMEBACK",
                EnclosedNumber = 2,
            };

            var Rock = new Dinosaur
            {
                Name = "Rock",
                DietType = "Carnivore",
                Weight = 10000,
                WhenAcquired = "COMEBACK TO THIS",
                EnclosedNumber = 3,
            };

            var Apple = new Dinosaur

            {
                Name = "Apple",
                DietType = "Carnivore",
                Weight = 5000,
                WhenAcquired = ,
                EnclosedNumber = 4,
            };

            var listOfDinosaurs = new List<Dinosaur>();
            listOfDinosaurs.Add(Ally);
            listOfDinosaurs.Add(Bob);
            listOfDinosaurs.Add(Rock);
            listOfDinosaurs.Add(Apple);

            Console.WriteLine();
            Console.WriteLine("Welcome to the zoo of Dinosaurs");
            Console.WriteLine();


            var userHasQuitApp = false;

            while (userHasQuitApp == false) ;

            {
                Console.WriteLine("Please select an option from the following choices:");

                Console.WriteLine("(V)iew the list of Dinosaurs that are currently as the zoo!");

                Console.WriteLine("(A)dd a new Dinosaur to our list!");

                Console.WriteLine("(R)emove a Dinosaur from our list.");

                Console.WriteLine("(T)ransfer a Dinosaur to a new pin.");

                Console.WriteLine("(S)ummary of the Dinosaurs diet.");

                Console.WriteLine("(Q)uit the Application.");


                var choice = PromptForString("Choice: ");

                if (choice == "V")
                {

                }
            }





        }
    }
}
