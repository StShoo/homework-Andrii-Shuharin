using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            task_1();
            task_2();
            task_3();
        }

        // Task 1
        private static void task_1()
        {
            Console.Write("Please enter first number:");
            int firstValue = ReadValue();
            Console.Write("Please enter second number:");
            int secondValue = ReadValue();
            Console.Write("Please enter operation: ");
            char sign = ReadSign();
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

        private static char ReadSign()
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


        private static double MakeCalculations(int firstValue, int secondValue, char sign)
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
        
        // Task 2
        private static void task_2()
        {
            Console.Write("Enter int number: ");
            int value = ReadValue();
            DefineSegment(value);
        }
        private static void DefineSegment(int value)
        {
            if (value is >= 0 and <= 14)
            {
                Console.WriteLine("Your value is in [0 - 14]");
            } else if (value is >= 15 and <= 35)
            {
                Console.WriteLine("Your value is in [15 - 35]");
            } else if (value is >= 36 and <= 50)
            {
                Console.WriteLine("Your value is in [36 - 50]");
            } else if (value is >= 51 and <= 100)
            {
                Console.WriteLine("Your value is in [51 - 100]");
            }
            else
            {
                Console.WriteLine("Your numbers lays in other segment");
            }
        }

        //Task 3
        private static void task_3()
        {
            FindInDictionary(CreateDictionary(), EnterUkrainianWord());
        }

        private static string EnterUkrainianWord()
        {
            Console.WriteLine("Enter word to translate: ");
            string word = Console.ReadLine() ?? string.Empty;
            word = word.ToLower();
            return word;
        }

        private static Dictionary<int, Translation> CreateDictionary()
        {
            var uaUkDictionary = new Dictionary<int, Translation>()
            {
                {0, new Translation {Ukranian = "сонячно", English = "Sunny"}},
                {1, new Translation {Ukranian = "пасмурно", English = "Mainly cloudy"}},
                {2, new Translation {Ukranian = "легкий дощ", English = "Light rain"}},
                {3, new Translation {Ukranian = "туман", English = "Fog"}},
                {4, new Translation {Ukranian = "хурделиця", English = "Blizzard"}},
                {5, new Translation {Ukranian = "сильний дощ", English = "Heavy rain"}},
                {6, new Translation {Ukranian = "гроза", English = "Thunderstorm"}},
                {7, new Translation {Ukranian = "волого", English = "Wet"}},
                {8, new Translation {Ukranian = "засуха", English = "Drought"}},
                {9, new Translation {Ukranian = "спека", English = "Hot"}}
            };
            return uaUkDictionary;
        }

        private static void FindInDictionary(Dictionary<int, Translation> uaUkDictionary, string wordToTranslate)
        {
            for (int i = 0; i < uaUkDictionary.Count; i++)
            {
                if (wordToTranslate.Equals(uaUkDictionary[i].Ukranian))
                {
                    Console.WriteLine($"Translation for {wordToTranslate} is {uaUkDictionary[i].English}");
                    break;
                }
            }

            Console.WriteLine("Sorry I don't know this word");
        }
    }

    public class Translation
    {
        public string Ukranian { get; set; }
        public string English { get; set; }
    }
}