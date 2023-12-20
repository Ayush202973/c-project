using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day2Project2
    {
        public void DisplayProject2Day2()
        {
            Console.WriteLine("Enter a three letters string");
            string str = Console.ReadLine();
            char[] arrString= str.ToCharArray();    
           Array.Reverse(arrString);
            string reverseStr = new string(arrString);
            Console.WriteLine(reverseStr);  
            

           
           
        }
    }
}
