
using System;

namespace ProblemStatement2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ch = -1;
            while (ch != 0) {
                Console.WriteLine();
                Console.WriteLine("0.Exit\n1.Flip Coins\n2.Leap Year\n3.Power of 2\n4.Harmonic\n5.Prime Factors\n6.Quotient and Remainder\n7.Swap\n8.Odd or Even\n9.Vowel or Consonants\n10.Largest of 3");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                { 
                    case 1:
                        FlipCoins flipCoins = new FlipCoins();
                        flipCoins.FlipPercent();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.CheckLeapYear();
                        break;
                    case 3:
                        PowerOf2 powerOf2 = new PowerOf2();
                        powerOf2.CalculatePower();
                        break;
                    case 4:
                        Harmonic harmonic = new Harmonic();
                        harmonic.HarmonicNumber();
                        break;
                    case 5:
                        Prime prime = new Prime();
                        prime.PrimeFactors();
                        break;
                    case 6:
                        Division division = new Division();
                        division.divide();
                        break;
                    case 7:
                        Swap swap = new Swap();
                        swap.Swap2Nums();
                        break;
                    case 8:
                        OddOrEven oddeven = new OddOrEven();
                        oddeven.OddorEven();
                        break;
                    case 9:
                        VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                        vowelOrConsonant.VowelOrCons();
                        break;
                    case 10:
                        Largest largest = new Largest();
                        largest.LargestOf3();
                        break;
                    default:
                        Console.WriteLine("Enter 0-10");
                        break;
                }
            }
            
        }
    }
}