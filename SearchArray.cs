using System;


namespace GuessTheGame
{
    public class SearchArray
    {
        public void DisplaySearch()
        {
            Console.WriteLine("Enter the size of an array");
            int arraySize=Convert.ToInt32(Console.ReadLine());
            char[] abc = new char[arraySize];
            Console.WriteLine("Enter the value of array");
          for(int i = 0; i < arraySize; i++)
            {
                abc[i]=Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Entered Array value is");


            for(int i=0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }



            Console.WriteLine("Enter which character you want to find");
            char input = Convert.ToChar(Console.ReadLine());

            for(int i = 0; i < abc.Length; i++)
            {
                if (abc[i] == input)
                {
                    Console.WriteLine(abc[i]);
                }
            }
        }
        
    }
}
