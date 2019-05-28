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
                    //DIVIDE EACH NUMBER BY THE OTHER NUMBERS OF A GIVEN ARRAY (2 TO 100) EXCEPT DIVIDING BY THE FACTORS
                    //1 AND THE NUMBER ITSELF TO CHECK WHETHER THE NUMBER IS PRIME OR NOT; THOUGH 1 IS NOT CONSIDERED HERE
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
            Console.WriteLine("INPUT: Numbers are given as from 1 to 100:");           
            Console.WriteLine();
            Console.WriteLine("OUTPUT: Following are the prime numbers as from 1 to 100:");
            Console.WriteLine("=========================================================");           
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadLine();
        }
    }
}
