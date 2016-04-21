using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    public class Output
    {
        public static void printIntegers()
        {
            int i = 0;
            while(true)
            {
                Console.Write(i++ + " ");
            }
        }
        public static string printIntegers(int repeat)  // overload printIntegers method
        {
            // for testing
            string str = "";
            for (int i = 0; i < repeat; i++)
            {
                str += i + " ";
            }
            return str;
        }
        public static void printFibonacci()
        {
            int f1 = 1;
            int f2 = 1;
            Console.Write("1 1 ");
            while(true)
            {
                int f = f1 + f2;
                Console.Write(f + " ");
                f1 = f2;
                f2 = f;
            }
        }
        public static string printFibonacci(int repeat)  // overload printFibonacci method
        {
            // for testing
            int f1 = 1;
            int f2 = 1;
            string str = "1 1 ";
            for (int j = 2; j < repeat; j++)
            {
                int f = f1 + f2;
                str += f + " ";
                f1 = f2;
                f2 = f;
            }
            return str;
        }

        public static void printPrimes()
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            Console.Write("2 ");
            int testNum = 3;
            int max = 100000;
            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (testNum < max)
            { 
                bool isPrime = true;  // reset flag
                for (int i = 0; i < primes.Count; i++)
                {
                    if (testNum % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(testNum);
                    //Console.Write(testNum + " ");
                }
                testNum += 2;
            }
            watch.Stop();
            Console.WriteLine("\n{0} milliseconds to find all {2:n0} primes less than {1:n0}", watch.ElapsedMilliseconds, max, primes.Count);
        }

        public static string printPrimes(int repeat)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            string str = "";
            for (int j = 0; j < repeat; j++)
            {
                str += primes[j] + " ";
            }
            return str;
        }

    }
}
