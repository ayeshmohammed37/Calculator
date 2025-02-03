namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int operation;
            int result;

            Console.WriteLine("Hello, Welcome to the calculator program");
            
            Console.Write("Please Enter your first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter your second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine()); 

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
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
            }


        }
    }
}
