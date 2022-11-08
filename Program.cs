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
        private static void task_1()
        {
            Console.Write("Please enter first number:");
            int firstValue = ReadValue();
            Console.Write("Please enter second number:");
            int secondValue = ReadValue();
            Console.Write("Please enter operation: ");
            char sign = ReadSighn();
            var result = MakeCalculations(firstValue,secondValue, sign);

            if (!(IsSecondValueZero(secondValue) && IsOperationDivision(sign)))
            {
                PrintResult(result, ComposeOperationToString(firstValue, secondValue, sign));
            }
            else
            {
                Console.Write("Operation is impossible");
            }
        }

        private static int ReadValue()
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

        static char ReadSighn()
        {
            do
            {
                try
                {
                    var sign = Convert.ToChar(Console.ReadLine() ?? string.Empty);
                    if (sign is '+' or '-' or '/' or '*')
                    {
                        return sign;
                    }
                    Console.WriteLine("Please enter only available sign: +, -, *, =");
                }
                catch
                {
                    Console.WriteLine("Please enter only available sign");
                }

            } while (true);
        }


        static double MakeCalculations(int firstValue, int secondValue, char sign)
        {
            double result;

            switch (sign)
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
                    if(IsSecondValueZero(secondValue))
                    {
                        Console.WriteLine("secondValue is equal to 0, can`t perform the operation");
                        
                        result = 0;
                        break;
                    }
                    result = Convert.ToDouble(firstValue) / Convert.ToDouble(secondValue);
                    break;
                default:
                    result = 0;
                    Console.WriteLine("Error is occured, answer is set to 0");
                    break;
            }
            return result;
        }

        private static bool IsSecondValueZero(int secondValue)
        {
            bool isSecondValueZero = secondValue == 0;
            return isSecondValueZero;
        }

        private static bool IsOperationDivision(char sign)
        {
            bool isDivision = sign == '/';
            return isDivision;
        }

        private static void PrintResult(double result, string operation)
        {
            Console.WriteLine($"{result}={operation}");
        }

        private static string ComposeOperationToString(int firstValue, int secondValue, char operationSign)
        {
            string operation = Convert.ToString(firstValue) + operationSign + Convert.ToString(secondValue);
            return operation;
        }
    }
}