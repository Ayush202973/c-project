﻿using System;


namespace GuessTheGame
{
    public class DisplayResult
    {
        public void Display()
        {
            Console.WriteLine("--------Shree Ambika Secondary----------\n" +
                "------Pokhara 25,Hemja-------");
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("MARKSHEET OF" + " " + name);
            string[] arr = {"Maths","English","Physics","Social","Chemistry","VP","CT","CN","SEP" };
            double obtainedMarks = 0;
        
            int [] marks= new int[arr.Length];
            for(int i=0; i<arr.Length; i++) 
            {
                Console.WriteLine("Enter your marks in" +" "+ arr[i]);
                marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[i]+" " + marks[i]);
                obtainedMarks = obtainedMarks+marks[i];
               

              

            }
          Console.WriteLine("Obtained marks is"+" "+obtainedMarks);
            double total = 900;
            double percentage=(obtainedMarks/total)/100;
            Console.WriteLine("Total Marks" + " " + total);
            
            Console.WriteLine("Your total Percentage is:"+percentage+"%");
            
    }
    }
}
