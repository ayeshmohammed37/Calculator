namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            int operation;
            double result;

            Console.WriteLine("Hello, Welcome to the calculator program");
            
            Console.Write("Please Enter your first Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter your second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Enter Number of Operation you want to do:\n1. +\n2. -\n3. *\n4. /");
            operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else if (operation == 2)
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
            }
            else if (operation == 3)
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
            }
            else
            {
                if(num2 == 0)
                {
                    Console.WriteLine("You can not devide by zero");
                    return;
                }
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
            }

            Console.ReadKey();
        }
    }
}
