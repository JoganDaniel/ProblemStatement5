using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter year");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%4==0 && (n%100 !=0 || n%400 ==0))
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
