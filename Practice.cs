//Program to add 10 in all array elements by using for loop

using System;


namespace GuessTheGame
{
    public class Practice
    {
        public void ForLoopPractice()
        {

            int[] arr = { 2, 4, 6, 8, 10 };
            Console.WriteLine("Before adding 10");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("After Adding 10:");
            for (int i = 0; i < arr.Length; i++)
            {
                int arrayValue = arr[i] + 10;
                Console.WriteLine(arrayValue);

            }

        }
    }
}





