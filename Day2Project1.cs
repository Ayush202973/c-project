using System;


namespace ConsoleApp1
{
  public class Day2Project1
    {
        public void DisplayProject1Day2()
        {
            Console.WriteLine("Input the First Number ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input The Second Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul=num1* num2;
            int div = num1 / num2;
            int mod = num1 % num2;
            Console.WriteLine(num1 + "+" + num2 +"="+ sum);
            Console.WriteLine(num1 + "-" + num2 + "=" + sub);
            Console.WriteLine(num1 + "*" + num2 + "=" + mul);
            Console.WriteLine(num1 + "/" + num2 + "=" + div);
            Console.WriteLine(num1 + "%" + num2 + "=" + mod);

        }
    }
}
