//Program to find whether a entered year is leap year or not .

using System;


namespace GuessTheGame
{
    public class LeapYear
    {

        public void DisplayLeapYear()
        {
            Console.WriteLine("Enter an Year");
            int year = Convert.ToInt32(Console.ReadLine());
            int leapYearResult = (year % 4 == 0 || year % 400 == 0) ? year : 0;
            Console.WriteLine(year + " " + "is a leap year");
        }
    }
}
