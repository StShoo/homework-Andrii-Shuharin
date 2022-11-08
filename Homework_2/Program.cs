using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            task1();

            // Task 3
            task2();

            Console.ReadKey();
        }

        static void task1()
        {
            Console.WriteLine("----Task 1----");
            double pi = 3.141592653;
            decimal e = 2.7182818284590452m;

            Console.WriteLine(pi);
            Console.WriteLine(e);
        }

        static void task2()
        {
            Console.WriteLine("----Task 2----");

            String paragraphExample = "\nмiй рядок 1";
            String tabExample = "\tмiй рядок 2";
            String warningExample = "\aмiй рядок 3";

            Console.WriteLine(paragraphExample + tabExample + warningExample);
        }
    }
}
