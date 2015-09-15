using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MersennePrimes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var primeList = GeneratePrimes(1000);
            foreach (var i in primeList)
            {
                if (IsMersennePrime(i))
                {
                    Console.WriteLine("p." + i + "\tMp:" + (Math.Pow(2, i) - 1));
                }
            }
            Console.ReadKey();
        }

        private static IEnumerable<int>GeneratePrimes(int toGenerate)
        {
            var primes = new List<int> { 2, 3 };
            while (primes.Count < toGenerate)
            {
                var nextPrime = (primes[primes.Count - 1]) + 2;
                while (true)
                {
                    var isPrime = primes.All(n => nextPrime % n != 0);
                    if (isPrime)
                    {
                        break;
                    }
                    nextPrime += 2;
                }
                primes.Add(nextPrime);
            }
            return primes;
        }

        private static bool IsMersennePrime(int n)
        {
            var x = Math.Pow(2, n) - 1;
            return IsPrime((int)x);
        }

        private static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }
            var num = Math.Sqrt(candidate);
            for (var i = 3; i <= num; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}