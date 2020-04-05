using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homeWorkLesson12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Id первичного потока:{Thread.CurrentThread.GetHashCode()}");

            Action action = new Action(Method);

            AsyncCallback asyncCallback = new AsyncCallback(Callback);
            
            action.BeginInvoke(asyncCallback, null);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("+");
            }

            Console.ReadKey();
        }

        static void Callback(IAsyncResult asyncResult)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\nМетод Callback отработал! Id потока:{Thread.CurrentThread.GetHashCode()}");
        }
        static void Method()
        {
            Console.WriteLine($"Id вторичного потока:{Thread.CurrentThread.GetHashCode()}");

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.Write("-");
            }
        }
    }
}
