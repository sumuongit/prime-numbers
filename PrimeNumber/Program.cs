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
            Console.WriteLine("Following are the prime numbers of 1 to 100");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadLine();
        }
    }
}
