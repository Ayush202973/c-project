using System;
//Program to print a string entered by user

namespace GuessTheGame
{
    public class StringQ1
    {
        public void Question1()
        {
            Console.WriteLine("Program to displya a string entered by user");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();
            Console.WriteLine(str);

        }
        public void Question2()
        {

            Console.WriteLine("Program to display a sentence I love candies");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
           
            Console.WriteLine($"Enter \"I Love Candies\" ");
            string sentence=Console.ReadLine();
            Console.WriteLine(sentence);
        }
        public void Question3() 
        {

            Console.WriteLine("Program to find the length of refrigerator");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            string str = "refrigerator";
            int lengthOfStr=str.Length;
            Console.WriteLine("Length of refrigerator is:"+lengthOfStr);
        
        }
        public void Question4()
        {

            Console.WriteLine("Program to Check if Umberalla contains letter e");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            string str = "Umberalla";
            bool containOrNot = str.Contains("e");
            Console.WriteLine("Umberalla Contains letter e:"+containOrNot);
        }
        public void Question5()
        {
            Console.WriteLine("Program to check if The word Orange is present in the sentence This is orange juice");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            string sentence = "This is Orange Juice";
            bool containOrange=sentence.Contains("Orange");
            Console.WriteLine("The sentence contains Orange:"+containOrange);
        
        }
        public void Question6()
        {
            string str = "Hello, World";
            Console.WriteLine("First Occurrence of o:"+ str.IndexOf("o"));
            Console.WriteLine("Last Occurrence of o:" + str.LastIndexOf("o"));
            Console.WriteLine("First Occurrence of ,:" + str.IndexOf(","));
            Console.WriteLine("First Occurrence of ,:" + str.LastIndexOf(","));


        }


    }
}
