using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day1Project3
    {
        public void DisplayProject3()
        {
            Console.WriteLine("Enter two numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int div = num1 / num2;
            Console.WriteLine("Division of two numbers is"+div);

        }
    }
}
