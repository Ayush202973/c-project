using System;


namespace GuessTheGame
{
    public class LetterCheck
    {
        public void AlphabetOrVowel()
        {
            Console.WriteLine("Enter a letter");
            char letter=Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter =='o' || letter=='o')
            {
                Console.WriteLine("Entered character is Vowel Letter");

            }
            else
            {
                Console.WriteLine("Entered character is Consonant letter");
            }

        }
    }
}
