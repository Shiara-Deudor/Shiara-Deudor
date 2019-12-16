using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            char operation;
            char redo;
            do
            {
                Console.Write("Please enter an operation which you like to calculate (+,-,*,/): ");
                operation = char.Parse(Console.ReadLine());
                Console.Write("Enter two numbers(");
                Console.Write(operation);
                Console.Write("):");
                Console.Write("\n");
                Console.Write("1st num: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("2nd num: ");
                num2 = double.Parse(Console.ReadLine());
                switch (operation)
                {
                    case '+':
                        Console.Write("The sum of two numbers (");
                        Console.Write(num1);
                        Console.Write(",");
                        Console.Write(num2);
                        Console.Write("): ");
                        Console.Write(num1 + num2);
                        Console.Write("\n");
                        break;
                    case '-':
                        Console.Write("The difference of two numbers (");
                        Console.Write(num1);
                        Console.Write(",");
                        Console.Write(num2);
                        Console.Write("): ");
                        Console.Write(num1 - num2);
                        Console.Write("\n");
                        break;
                    case '*':
                        Console.Write("The product of two numbers (");
                        Console.Write(num1);
                        Console.Write(",");
                        Console.Write(num2);
                        Console.Write("): ");
                        Console.Write(num1 * num2);
                        Console.Write("\n");
                        break;
                    case '/':
                        Console.Write("The quotient of two numbers (");
                        Console.Write(num1);
                        Console.Write(",");
                        Console.Write(num2);
                        Console.Write("): ");
                        if (num2 == 0)
                        {
                            Console.Write("not valid");
                            Console.Write("\n");
                        }
                        Console.Write((num1 / num2));
                        Console.Write("\n");
                        break;
                    default:
                        Console.Write("INVALID OPERATION!");
                        Console.Read();
                        break;
                }
                Console.Write("Press y or Y to continue: \n");
                redo = char.Parse(Console.ReadLine());
            } while (redo == 'y' || redo == 'Y');

            return;

        }
    }
}
