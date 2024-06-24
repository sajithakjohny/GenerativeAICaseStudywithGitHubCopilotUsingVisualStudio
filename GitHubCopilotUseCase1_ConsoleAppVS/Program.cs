using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubCopilotUseCase1_ConsoleAppVS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generate calculator program
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();                
            Console.WriteLine("Enter the second number: ");
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
                
        }
    }
}
