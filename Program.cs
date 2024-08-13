using System;
using System.Runtime.InteropServices;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Simple Calculator!");

            Console.Write("Enter the first number: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the operation (+,-,*,/): ");

            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            bool validOperation = true;

            switch (operation)
            {
                case '+':

                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        validOperation = false;
                    }
                    break;
                default:

                    Console.WriteLine("Invalid operation.");

                    validOperation = false;
                    break;

            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }

        }
    }
}