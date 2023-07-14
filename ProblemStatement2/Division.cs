using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class Division
    {
        public void divide()
        {
            Console.WriteLine("Enter Dividend");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient : " + n / n2);
            Console.WriteLine("Remainder : "+n % n2);
        }
    }
}
