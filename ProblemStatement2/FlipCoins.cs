using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class FlipCoins
    {
        public void FlipPercent() 
        {
            Console.WriteLine("Enter the number of times u want to toss");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int head = 0, tail = 0;
            for(int i = 0; i < n; i++)
            {
                double d = random.NextDouble();
                if (d > 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            Console.WriteLine("Head percentage :"+(100*head)/n);
            Console.WriteLine("Tail percentage :" + (100 * tail) / n);

        }
    }
}
