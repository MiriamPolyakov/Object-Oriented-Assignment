using Object_Oriented_Assignment;
using System;

namespace Object_Orientae_Assignment;

public class Program
{

    static void Main(string[] args)
    {
        /// <summary>
        /// Presents options for interacting with a Dog object and displays the Dog's responses
        /// based on user selections.
        /// </summary>
        void dogChoice()
        {
            Dog dog = new Dog();
            string? dogChoice;
            Console.WriteLine("Hi! I'm the dog... I live on land (a terrestrial animal) and I'm mammalian and carnivorous");
            do
            {
                Console.WriteLine("\n choose what you want from me to do:");
                Console.WriteLine(" 1 - greet you 😀 \n 2 - I'm feeling comfortable being touched \n " +
                    "3 - I'm frightened \n 4 - I'm upset \n 5 - Exit");
                // Read the user's input as a string
                dogChoice = Console.ReadLine();
                switch (dogChoice)
                {
                    case "1":
                        Console.WriteLine(dog.Greet());
                        break;

                    case "2":
                        Console.WriteLine(dog.ComfortableBeingTouched());
                        break;
                    case "3":
                        Console.WriteLine(dog.ActByFeeling(Emotion.Frightened));
                        break;
                    case "4":
                        Console.WriteLine(dog.ActByFeeling(Emotion.Upset));
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Wrong choice, try agin.");
                        break;
                }
            } while (dogChoice != "5");
        }

        /// <summary>
        /// Presents options for interacting with a Cat object and displays the Cat's responses
        /// based on user selections.
        /// </summary>
        void catChoice()
        {
            Cat cat = new Cat();
            string? catChoice;
            Console.WriteLine("Hi! I'm the cat... I live on land (a terrestrial animal) and I'm mammalian and carnivorous");
            do
            {
            Console.WriteLine("\n choose what you want from me to do:");
            Console.WriteLine(" 1 - greet you 😀 \n 2 - I'm frightened \n 3 - I'm in Good Mood \n 4 - Exit");
            // Read the user's input as a string
            catChoice = Console.ReadLine();
            switch (catChoice)
            {
                case "1":
                    Console.WriteLine(cat.Greet());
                    break;
                case "2":
                    Console.WriteLine(cat.ActByFeeling(Emotion.Frightened));
                    break;
                case "3":
                    Console.WriteLine(cat.ActByFeeling(Emotion.GoodMood));
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Wrong choice, try agin.");
                    break;
            }
            } while (catChoice != "4");
        }

        /// <summary>
        /// Presents options for interacting with a Frog object and displays the Frog's responses
        /// based on user selections. (Note: Frog cannot greet)
        /// </summary>
        void frogChoice()
        {
            Frog frog = new Frog();
            string? frogChoice;
            Console.WriteLine("Hi! I'm the frog... I'm an amphibian (a terrestrial animal) and I'm not mammalian and carnivorous");
            do
            {
            Console.WriteLine("\n choose what you want from me to do:");
            Console.WriteLine(" 1 -  I'm frightened \n 2 - I'm in Good Mood \n 3 - Exit");
            // Read the user's input as a string
            frogChoice = Console.ReadLine();
            switch (frogChoice)
            {
                case "1":
                    Console.WriteLine(frog.ActByFeeling(Emotion.Frightened));
                    break;
                case "2":
                    Console.WriteLine(frog.ActByFeeling(Emotion.GoodMood));
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Wrong choice, try agin.");
                    break;
            }
            } while (frogChoice != "3");
        }


        /// <summary>
        /// Welcomes the user, prompts for animal selection, and calls the corresponding function 
        /// (dogChoice, catChoice, or frogChoice) to handle user interaction.
        /// Handles potential exceptions using a try-catch block.
        /// </summary>
        try
        {

            Console.WriteLine("Hello to Object Oriented Assignment");
            Console.WriteLine("Do you want to see our animals? Let's take a look.");
            string? userInput;
            do
            {
            Console.WriteLine("Please choose an animal you want to look at: \n 1 - Dog \n 2 - Cat \n 3 - Frog \n 4 - Exit");

            // Read the user's input as a string
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    dogChoice();
                    Console.WriteLine();
                    break;

                case "2":
                    catChoice();
                    Console.WriteLine();
                    break;

                case "3":
                    frogChoice();
                    Console.WriteLine();
                    break;
                case "4":
                    break;

                default:
                    Console.WriteLine("Wrong choice, try agin.");
                    break;
            }
            } while (userInput != "4");

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}
