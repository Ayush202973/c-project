using System;


namespace ConsoleApp1
{
    public  class Day1Project2
    {
        public void DisplayProject2()
        {
            Console.WriteLine("Ente two numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum of entered two numbers is"+sum); 

        }
    }
}
