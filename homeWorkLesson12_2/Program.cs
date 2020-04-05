using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[1000000];

            Random random = new Random();

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = random.Next(1, 50);
            }

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            //var notParallelNumbers = from number in numberArray
            //                         where number % 2 != 0
            //                         select number;

            var parallelNumbers = from number in numberArray.AsParallel()
                                  where number % 2 != 0
                                  select number;

            stopWatch.Stop();

            Console.WriteLine($"Elapsed time: {stopWatch.ElapsedMilliseconds} ms!");

            Console.ReadKey();
        }
    }
}
