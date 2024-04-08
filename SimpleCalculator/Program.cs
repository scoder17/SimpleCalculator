using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Select Operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice (1/2/3/4/5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                string operation = "";

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        operation = "Addition";
                        break;
                    case "2":
                        result = num1 - num2;
                        operation = "Subtraction";
                        break;
                    case "3":
                        result = num1 * num2;
                        operation = "Multiplication";
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            Console.WriteLine("");
                            continue;
                        }
                        result = num1 / num2;
                        operation = "Division";
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        continue;
                }

                Console.WriteLine($"{operation} Result: {result}");
                Console.WriteLine("");
            }
        }
    }
}
