using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class Harmonic
    {
        public void HarmonicNumber()
        {
            Console.WriteLine("Enter the limit");
            double har = 0.0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                har += 1 / i;
            }
            Console.WriteLine(har);
        }
    }
}
