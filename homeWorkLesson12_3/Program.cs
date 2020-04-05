using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homeWorkLesson12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен!");

            ParallelOptions options = new ParallelOptions
            {
                MaxDegreeOfParallelism = 2
            };

            Parallel.Invoke(options, Method_1, Method_2);

            //Task.Run(Method_1);
            //Task.Run(Method_2);

            Console.WriteLine("Основной поток завершен!");

            Console.ReadKey();
        }

        static void Method_1()
        {
            Console.WriteLine("Method_1 запущен!");

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(50);

                Console.Write("1");
            }
            Console.WriteLine("\nMethod_1 прекратил работу!");
        }
        static void Method_2()
        {
            Console.WriteLine("Method_2 запущен!");

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(50);

                Console.Write("2");
            }
            Console.WriteLine("\nMethod_2 прекратил работу!");
        }
    }
}
