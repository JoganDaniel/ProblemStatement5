using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class Largest
    {
        public void LargestOf3()
        {
            Console.WriteLine("Enter 3 nums");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int ans = (a>b && a>c) ? a : (b>c && b>a) ? b : c;
            Console.WriteLine("Largest num is "+ans);
        }
    }
}
