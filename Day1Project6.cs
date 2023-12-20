using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day1Project6
    {
        public void DisplayProject6()
        {
            Console.WriteLine("Enter three numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int num3=Convert.ToInt32(Console.ReadLine());
            int mul=num1*num2*num3;
            Console.WriteLine("Multiplication of three entered numbers is "+ mul);
        }
    }
}
