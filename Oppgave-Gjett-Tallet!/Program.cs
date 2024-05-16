using System.ComponentModel.Design;

namespace Oppgave_Gjett_Tallet_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100
            // Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere, helt til man gjetter riktig tall.
            // Da skal man få spørsmål om man vil spille på nytt.

            Random r = new Random();

            guessTheNumber();
            void guessTheNumber()
            {
               int randomNumber = r.Next(1, 100);
               Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

               bool guessedTheNumber = false;
               while (!guessedTheNumber)
               {
                   int userInput = Convert.ToInt32(Console.ReadLine());

                   if (userInput < randomNumber)
                   {
                        Console.WriteLine("You guessed to low. Try again!");
                   }
                   else if (userInput > randomNumber)
                   {
                        Console.WriteLine("You guessed to high. Try again!");
                   }
                   else if (userInput == randomNumber)
                   {
                        Console.WriteLine("You guessed correct!!! Congrats!!");
                        guessedTheNumber = true;
                   }
               }

               if (guessedTheNumber)
               {
                   Console.WriteLine("Do you wanna play again? y/n");
                   string userInput = Console.ReadLine();
                   if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                   {
                       Console.Clear();
                       guessTheNumber();
                   }
                   else
                   {
                       Console.WriteLine("Goodbye!");
                       Environment.Exit(0);
                   }
               }
            }
        }
    }
}
