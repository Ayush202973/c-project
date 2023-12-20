using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 public class Day1Project5
    {
        public void Displayproject5()
        {
            Console.WriteLine("Enter Two numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values before Swapping " + " a = " + a + " and " + " b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Values After Swapping " + " a = " + a + " and " + " b = " + b);
        }
    }
}
