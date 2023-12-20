//Program to access multi-dimensional Array
using System;


namespace GuessTheGame
{
    public class AccessMultiDimensionalArray
    {

        public void DisplayArray()
        {
            int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 }, };
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.WriteLine(arr2D[i, j]);
                }

            }

        }
    }
}
