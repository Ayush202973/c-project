//Program to get array userinput from user
using System;


namespace GuessTheGame
{
    public class ArrayUserInput
    {
        public void UserInput()
        {
            Console.WriteLine("Enter the size of an array");
            int user = Convert.ToInt32(Console.ReadLine());
            int[] arrayDeclare = new int[user];
            Console.WriteLine("Enter the array value");
            for (int i = 0; i < arrayDeclare.Length; i++)
            {
                arrayDeclare[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Entered Array Element is");
            for (int i = 0; i < arrayDeclare.Length; i++)
            {
                Console.WriteLine(arrayDeclare[i]);
            }
            Console.WriteLine("Array fourth element is:" + arrayDeclare[3]);


        }
    }
}
