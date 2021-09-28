using System;

namespace Calculator
{
    class Calculator
    {
        public static string input, StringBeforeSign = "", StringAfterSign = "", sign;
        public static double num, num1, num2;
        public Calculator()
        {
            ReStart();
            static void ReStart()
            {
                StringBeforeSign = "";
                StringAfterSign = "";
                string StringVertical = "";
                sign = "";
                Console.WriteLine("Приклад для розрахунку: ");
                Console.WriteLine("Якщо хочете провести операцію у вертикальому положені - введіть '1': ");
                char[] MassiveOfNeedElements = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+', '-', '*', '.', ',' };
                char[] MassiveOfNeedElements2 = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ',' };
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Введіть перше число: ");
                    StringBeforeSign = Console.ReadLine();
                    Console.WriteLine("Введіть знак операції: ");
                    sign = Console.ReadLine();
                    Console.WriteLine("Введіть друге число: ");
                    StringAfterSign = Console.ReadLine();
                    foreach (char n in StringBeforeSign)
                    {
                        for (int i = 0; i < MassiveOfNeedElements2.Length; i++)
                        {
                            if (MassiveOfNeedElements2[i] == n)
                            {
                                if (n == '.')
                                {
                                    StringVertical = StringVertical + ",";
                                    continue;
                                }
                                else
                                {
                                    StringVertical = StringVertical + Convert.ToString(n);
                                }
                            }
                        }
                    }
                    num1 = Convert.ToDouble(StringVertical);
                    StringVertical = "";
                    if (sign != "+" && sign != "-" && sign != "*")
                    {
                        Console.WriteLine("Некорекне введення даних");
                        ReStart();
                    }
                    foreach (char n in StringAfterSign)
                    {
                        for (int i = 0; i < MassiveOfNeedElements2.Length; i++)
                        {
                            if (MassiveOfNeedElements2[i] == n)
                            {
                                if (n == '.')
                                {
                                    StringVertical = StringVertical + ",";
                                    continue;
                                }
                                else
                                {
                                    StringVertical = StringVertical + Convert.ToString(n);
                                }
                            }
                        }
                    }
                    num2 = Convert.ToDouble(StringVertical);
                    if (sign == "+")
                    {
                        ShowSumm();
                    }
                    else if (sign == "-")
                    {
                        ShowMinus();
                    }
                    else if (sign == "*")
                    {
                        ShowDobutok();
                    }
                }
                else
                {
                    foreach (char n in input)
                    {
                        for (int i = 0; i < MassiveOfNeedElements.Length; i++)
                        {
                            if (n == MassiveOfNeedElements[i])
                            {
                                if (n == '.')
                                {
                                    if (num1 != 0)
                                    {
                                        StringAfterSign = StringAfterSign + ",";
                                    }
                                    else
                                    {
                                        StringBeforeSign = StringBeforeSign + ",";
                                    }
                                    continue;
                                }
                                if (n == '+' || n == '-' || n == '*')
                                {
                                    num1 = Convert.ToDouble(StringBeforeSign);
                                    sign = Convert.ToString(n);
                                    continue;
                                }
                                else
                                {
                                    StringBeforeSign = StringBeforeSign + Convert.ToString(n);
                                }
                                if (sign == "+" || sign == "-" || sign == "*")
                                {
                                    StringAfterSign = StringAfterSign + Convert.ToString(n);
                                }
                            }
                        }
                    }
                    num2 = Convert.ToDouble(StringAfterSign);
                    if (sign == "+")
                    {
                        ShowSumm();
                    }
                    else if (sign == "-")
                    {
                        ShowMinus();
                    }
                    else if (sign == "*")
                    {
                        ShowDobutok();
                    }
                }
            }
        }
        public static void ShowSumm()
        {
            num = num1 + num2;
            Console.WriteLine("Відповідь: " + num);
        }
        public static void ShowMinus()
        {
            num = num1 - num2;
            Console.WriteLine("Відповідь: " + num);
        }
        public static void ShowDobutok()
        {
            num = num1 * num2;
            Console.WriteLine("Відповідь: " + num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Calculator calculate = new Calculator();
            Console.ReadLine();
        }
    }
}
