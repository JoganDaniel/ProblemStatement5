using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class PowerOf2
    {
        public void CalculatePower()
        {
            Console.WriteLine("Enter the power");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("2 ^ "+i+" = "+Math.Pow(10,i));
            }
        }
    }
}
