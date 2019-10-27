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
            Console.Write("Please type your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Thank you {0}.", firstName);
            Console.Write("Please type your last name: ");
            lastName = Console.ReadLine();

            // Get their favorite number
            Console.Write("{0}, what is your favorite number? ", firstName);
            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            // Get their favorite animal
            Console.Write("Finally, what is your favorite animal? ");
            favoriteAnimal = Console.ReadLine();

            // Once you have gotten all their info and stored it,
            // display it back to them.
            Console.WriteLine("\nOK {0} {1},", firstName, lastName);
            Console.WriteLine("let's see if I've recorded this correctly;");
            Console.WriteLine("your favorite animal is a(n) {0}, ", favoriteAnimal);
            Console.Write("and your Favorite number is ");

            // If their favorite number is greater than 10, display it in green.
            if (favoriteNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}.\n", favoriteNumber);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // If their favorite number is less than 5, display it in red.
            else if (favoriteNumber < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}.\n", favoriteNumber);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {

                // If 4 < favorite number < 11 then print it in the default color.
                Console.Write("{0}.\n", favoriteNumber);
            }

            Console.Write("Thank-you for your participation.\n");

        }
    }
}
