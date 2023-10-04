using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheGame
{
   public class LeetCodeProblem
    {

        public void DisplayProblem()
        {
            int[,] arr = { { 1, 2, 1 }, { 2, 2, 1 }, { 2, 1, 1 } };
            for(int i=0; i<arr.GetLength(0); i++) { 
           
            for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
               
                }
            Console.WriteLine("   ");
            }



            Console.WriteLine("After solving Question");


            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 2)
                    {
                        arr[i, j] = 1;
                    }else if (arr[i, j] == 1)
                    {
                        arr[i, j] = 2;
                    }
                    Console.Write(arr[i,j]);

                }
                Console.WriteLine("   ");
            }

        }
    }
}
