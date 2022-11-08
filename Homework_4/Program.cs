using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            task_1();

        }

        // Task 1
        static void task_1()
        {
            Console.WriteLine("Please enter two numbers:");

            makeCalculations(readValue(), readValue(), readSighn());
        }

        static int readValue()
        {
            do
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch 
                { 
                    Console.WriteLine("Please enter only int values"); 
                }
            } while (true);
        }

        static char readSighn()
        {
            Console.Write("Please enter operation: ");
            do
            {
                try
                {
                    char sighn = Convert.ToChar(Console.ReadLine());
                    if (sighn == '+' || sighn == '-' || sighn == '/' || sighn == '*')
                    {
                        return sighn;
                    }
                    Console.WriteLine("Please enter only avaliable sighns: +, -, *, =");
                }
                catch
                {
                    Console.WriteLine("Please enter only avaliable sighns");
                }

            } while (true);
        }


        static double makeCalculations(int firstValue, int secondValue, char sighn)
        {
            double result;

            switch (sighn)
            {
                case '+':
                    result = firstValue + secondValue;
                    break;
                case '-':
                    result = firstValue - secondValue;
                    break;
                case '*':
                    result = firstValue * secondValue;
                    break;
                case '/':
                    if(isSecondValueZero(secondValue))
                    {
                        Console.WriteLine("secondValue is equal to 0, can`t perform the operation");
                        result = 0;
                        break;
                    }
                    result = Convert.ToDouble(firstValue) / Convert.ToDouble(secondValue);
                    break;
                default:
                    result = 0;
                    Console.WriteLine("Error is ocured, answer is set to 0");
                    break;
            }
            return result;
        }

        static bool isSecondValueZero(int secondValue)
        {
            bool isSecondValueZero = secondValue == 0;
            return isSecondValueZero;
        }
    }
}
