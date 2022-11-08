using System;

namespace Homework_3
{
    class Program
    {
        const float pi = 3.14f;

        static void Main(string[] args)
        {
            task_1();

            task_2();

            task_3();

            task_4();

            task_7();
        }

        // Task 1
        static void task_1()
        {
            Console.WriteLine("--------------Task 1--------------");

            int x = 10, y = 12, z = 3;

            Console.WriteLine($"Our variables are: x = {x} y = {y} z = {z}");

            firstCalculation(x, y, z);
            secondCalculation(x, y, z);
            thirdCalculation(x, y, z);
            fourthCalculation(x, y, z);
            fifthCalculation(x, y, z);
        }


        static void print_var(double varToPrint, string toCount)
        {
            Console.WriteLine($"For: {toCount} \nAnswer is {varToPrint}");
        }

        // Five calculations methods:
        static void firstCalculation(int x, int y, int z)
        {
            x += y - x++ * z;
            print_var(x, "x += y - x++ * z");
        }

        static void secondCalculation(int x, int y, int z)
        {
            z = -x - y * 5;
            print_var(z, "z = -x - y * 5");
        }

        static void thirdCalculation(int x, int y, int z)
        {
            y /= x + 5 % z;
            print_var(y, "y /= x + 5 % z");
        }

        static void fourthCalculation(int x, int y, int z)
        {
            z = x + + +y * 5;
            print_var(z, "z = x + + + y * 5");
        }

        static void fifthCalculation(int x, int y, int z)
        {
            x = y - x++ * z;
            print_var(x, "x = y - x++ * z");
        }


        // Task 2
        static void task_2()
        {
            Console.WriteLine("--------------Task 2--------------");

            Console.Write("Enter number of your numbers: ");
            int sizeOfArray = enterIntNumber();
            int[] arrOfNumbers = new int[sizeOfArray];

            int sum = 0;

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} number: ");
                arrOfNumbers[i] = enterIntNumber();
            }

            printArray(arrOfNumbers);

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                sum += arrOfNumbers[i];
            }

            int midArithmetic = sum / arrOfNumbers.Length;

            Console.WriteLine($"Middle arithmetical is: {midArithmetic}");
        }

        static int enterIntNumber()
        {
            int numberToReturn;
            do
            {
                try
                {
                    numberToReturn = Convert.ToInt32(Console.ReadLine());
                    return numberToReturn;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry but number should be int!");
                }
            } while (true);
        }

        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1} element: {arr[i]}");
            }
        }


        // Task 3
        static void task_3()
        {
            Console.WriteLine("--------------Task 3--------------");

            Console.Write("Enter circle radius: ");
            float r = enterIntNumber();

            double S = pi * Math.Pow(r, 2);

            Console.WriteLine($"Circle with {r} radius will have S = {S}");
        }


        //Task 4
        static void task_4()
        {
            Console.WriteLine("--------------Task 4--------------");

            Console.Write("Enter cilinder radius: ");
            float r = enterIntNumber();
            Console.Write("Enter cilinder heigh: ");
            float h = enterIntNumber();

            double V = 2 * pi * r * h;
            double S = 2 * pi * r * (r + h);

            Console.WriteLine($"Cilinder with radius {r} and heigh {h}\nhas V = {V} and S = {S}");
        }

        // Task 7
        static void task_7()
        {
            Console.WriteLine("--------------Task 7--------------");

            Console.Write("Enter first number: ");
            double x = enterIntNumber();
            Console.Write("Enter second number: ");
            double y = enterIntNumber();
            double z;

            z = x + y;
            print_var(z, "x + y");

            z = x - y;
            print_var(z, "x - y");

            z = x / y;
            print_var(z, "x / y");

            z = x * y;
            print_var(z, "x * y");

            z = Math.Pow(x, y);
            print_var(z, "x ^ y");
        }
    }
}
