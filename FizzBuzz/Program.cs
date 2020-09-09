using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static Dictionary<int, string> factors = new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" }, {6, "AnotherTerm" } };
        // add a factor and the corresponding term for that factor if you want to expand

        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            // stopwatch stuff is just for finding runtime

            for (int i = 1; i < 101; i++)
            {
                string output = "";

                foreach (KeyValuePair<int, string> entry in factors)
                {
                    if (i % entry.Key == 0)
                    {
                        output += entry.Value;
                    }
                }

                if (output == "")
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }


            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
