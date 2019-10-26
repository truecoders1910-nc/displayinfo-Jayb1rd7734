using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, favoriteAnimal;
            int favoriteNumber;

            // Get first and last name from user input
            Console.Write("Please type your name: ");
            firstName = Console.ReadLine();
            Console.Write("Please type your lastName: ");
            lastName = Console.ReadLine();

            // Get their favorite number
            Console.Write("What is your favorite number? ");
            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            // Get their favorite animal
            Console.Write("What is your favorite animal");
            favoriteAnimal = Console.ReadLine();

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
