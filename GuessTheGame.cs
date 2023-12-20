// Program to guess the number entered by the user

using System;


namespace GuessTheGame
{
    public class GuessTheGame
    {
        public void PlayGame()
        {
            int randomNumber;
            int userGuess;
            Random random = new Random();
            randomNumber = random.Next(1, 100);
            bool guessstatus = false;

            while (!guessstatus)
            {
                Console.WriteLine("Guess the number:");
                userGuess = int.Parse(Console.ReadLine());


                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    guessstatus = true;
                    break;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");

                }
                else
                {
                    Console.WriteLine("Too high! Try again.");

                }
            }
        }
    }
}
