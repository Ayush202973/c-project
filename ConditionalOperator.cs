using System;


namespace GuessTheGame
{
    public class ConditionalOperator
    {
        public void OperatorDisplay()
        {
            Console.WriteLine("Enter a Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2= Convert.ToInt32(Console.ReadLine());
            int result = num1 > num2 ? num1 : num2;
            Console.WriteLine("Greater number is"+result);


        }
    }
}
