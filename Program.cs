using System;
using System.Collections.Generic;
using System.Linq;

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
                EnclosureNumber = 1,
            };

            var Bob = new Dinosaur
            {
                Name = "Bob",
                DietType = "Herbivore",
                Weight = 3000,
                WhenAcquired = DateTime.Now,
                EnclosureNumber = 2,
            };

            var Rock = new Dinosaur
            {
                Name = "Rock",
                DietType = "Carnivore",
                Weight = 10000,
                WhenAcquired = DateTime.Now,
                EnclosureNumber = 3,
            };

            var Apple = new Dinosaur

            {
                Name = "Apple",
                DietType = "Carnivore",
                Weight = 5000,
                WhenAcquired = DateTime.Now,
                EnclosureNumber = 4,
            };

            var listOfDinosaurs = new List<Dinosaur>();
            listOfDinosaurs.Add(Ally);
            listOfDinosaurs.Add(Bob);
            listOfDinosaurs.Add(Rock);
            listOfDinosaurs.Add(Apple);


            Console.WriteLine();
            Console.WriteLine("Welcome to the Zoo of Dinosaurs");
            Console.WriteLine();


            var userHasQuitApp = false;

            while (userHasQuitApp == false)

            {
                Console.WriteLine("Please select an option from the following choices:");

                Console.WriteLine("(V)iew the list of Dinosaurs that are currently as the zoo!");

                Console.WriteLine("(A)dd a new Dinosaur to our list!");

                Console.WriteLine("(R)emove a Dinosaur from our list.");

                Console.WriteLine("(T)ransfer a Dinosaur to a new pin.");

                Console.WriteLine("(S)ummary of the Dinosaurs diet.");

                Console.WriteLine("(Q)uit the Application.");


                var choice = PromptForString("Choice:");

                if (choice == "V")
                {
                    Console.WriteLine("Here is a list of the current Dinosaurs at the Zoo");

                    foreach (var dinosaur in listOfDinosaurs)
                    {

                        var orderDinosaursByTime = listOfDinosaurs.OrderBy(dinosaurs => dinosaurs.WhenAcquired);
                        var description = dinosaur.Description();

                        Console.WriteLine(description);
                    }
                }

                if (choice == "A")
                {
                    var newName = PromptForString("Name: ");
                    var newDietType = PromptForString("Diet Type: ");
                    var newWeight = PromptForInteger("Weight: ");
                    var newWhenAcquired = DateTime.Now;
                    var newEnclosureNumber = PromptForInteger("Enclosed Number: ");

                    var newDinosaur = new Dinosaur
                    {
                        Name = newName,
                        DietType = newDietType,
                        Weight = newWeight,
                        WhenAcquired = newWhenAcquired,
                        EnclosureNumber = newEnclosureNumber,
                    };
                    listOfDinosaurs.Add(newDinosaur);

                }

                if (choice == "Q")
                {
                    userHasQuitApp = true;
                }

                if (choice == "R")
                {
                    var findDinosaurToRemove = PromptForString("Name of Dinosaur to be removed: ");

                    var dinosaurFound = listOfDinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == findDinosaurToRemove);

                    if (dinosaurFound == null)
                    {
                        Console.WriteLine($"There is no Dinosaur by the name of {dinosaurFound}");
                    }

                    else
                    {
                        var foundDinosaurDescription = dinosaurFound.Description();
                        Console.WriteLine(foundDinosaurDescription);

                        var doYouWantToRemoveDinosaur = PromptForString("Would you like to remove a Dinosaur? (Y/N): ");

                        if (doYouWantToRemoveDinosaur == "Y")
                        {
                            listOfDinosaurs.Remove(dinosaurFound);
                        }
                    }

                }
                if (choice == "S")
                {
                    var typeOfDietHerbivore = listOfDinosaurs.Count(dinosaurs => dinosaurs.DietType == ("Herbivore"));
                    var typeOfDietCarnivore = listOfDinosaurs.Count(dinosaurs => dinosaurs.DietType == ("Carnivore"));

                    Console.WriteLine($"The number of carnivore is {typeOfDietCarnivore} and the number of herbivore is {typeOfDietHerbivore}");

                }

                if (choice == "T")
                {
                    var dinosaurName = PromptForString("Insert name of Dinosaur you are looking for: ");
                    var dinosaurFound = listOfDinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == dinosaurName);

                    if (dinosaurFound == null)
                    {
                        Console.WriteLine($"There is no Dinosaur by the name of {dinosaurFound}");
                    }

                    else
                    {
                        var foundDinosaurDescription = dinosaurFound.Description();
                        Console.WriteLine(foundDinosaurDescription);

                        var newEnclosureNumber = PromptForInteger("New Enclosure Number: ");

                        dinosaurFound.EnclosureNumber = newEnclosureNumber;
                    }


                }
            }





        }
    }
}
