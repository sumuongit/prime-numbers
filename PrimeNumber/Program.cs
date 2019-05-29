using System;
using System.Collections.Generic;

namespace PrimeNumber
{
    public class Prime
    {
        List<int> primeNumbers = new List<int>();
        bool isPrime = true;
        int i, j;

        public List<int> FindPrimeNumber()
        {
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= i-1; j++)
                {
                    // Divide each number by the other numbers of a given array (2 to 100) except dividing by the factors
                    // 1 and the number itself to check whether the number is prime or not; though 1 is not considered here.
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                }

                isPrime = true;
            }
            
            return primeNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prime pm = new Prime();
            List<int> result = pm.FindPrimeNumber();
            Console.WriteLine("INPUT: Numbers are given as from 2 to 100:");           
            Console.WriteLine();
            Console.WriteLine("OUTPUT: Following are the prime numbers as from 2 to 100:");
            Console.WriteLine("=========================================================");           
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadLine();
        }
    }
}
