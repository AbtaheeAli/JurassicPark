using System;

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
            // | Ally    |carnivore | 1 ton  |              | 1               |
            // | Bob     |herbivore | 3 ton  |              | 2               | 
            // | Rock    |carnivore | 10 ton |              | 3               | 
            // | Apple   |carnivore  | 5 ton |              | 4               | 
            var Ally = new Dinosaurs
            {
                Name = "Ally",
                DietType = "Carnivore",
                Weight = "1 ton",
            }
        }
    }
}
