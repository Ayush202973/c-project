using System;


namespace GuessTheGame
{
    public class Trial
    {
        public void Display1()
        {
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("See below information to know your marks in each subject\n" +
                "1.Maths\n" +
                "2.English\n" +
                "3.Social\n" +
                "4.CT\n" +
                "5.VP\n" +
                "6.CN\n" +
                "7.SEP\n" +
                "8.Physics\n" +
                "9.Chemistry\n" +
                "10.Total Percentage\n");
            Console.WriteLine("Choose which one you want to know");
            int student = Convert.ToInt32(Console.ReadLine());
            if (name == "Bishnu")
            { 


                
            }
            Console.WriteLine("Your Overall Percentage is 95%.Keep it up!");
        }
    }
}
