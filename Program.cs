using System;
using System.Collections.Generic;

namespace natural_primer_fibonacci_counters
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var num in createNatural(5))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            foreach (var fibo in createFibonacci(2))
            {
                Console.WriteLine(fibo);
            }

            Console.WriteLine("");
            foreach (var prime in createPrime(10))
            {
                Console.WriteLine(prime);
            }
        }

        public static IEnumerable<int> createNatural(int max)
        {
            for (int k = 1; k < max + 1; k++)
            {
                yield return k; 
            }
        }

        public static IEnumerable<int> createFibonacci(int top)
        {
            int first = 1, second = 1, third;
            yield return first;
            yield return second;
            for (int i = 0; i < top - 2; i++)
            {
                third = first + second;
                first = second;
                second = third;
                yield return third;
            }
        }

        public static IEnumerable<int> createPrime(int top)
        {
            for (int i = 0; i < top + 1; i++)
            {
                for (int k = 2; k < Math.Sqrt(i) + 1; k++)
                {
                    if (i%k == 0 & i != 2)
                    {
                        break;
                    }
                    else
                    {
                        yield return i;
                        break;
                    }
                }
            }
        }
    }
}