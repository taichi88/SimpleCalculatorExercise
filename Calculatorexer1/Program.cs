// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Operation Symbol \n+ \n- \n* \n/ ");
        string operation = Console.ReadLine();
        if (operation != "+" && operation != "-" && operation != "*" && operation != "/")

            Console.WriteLine("Error: invalid operations. ");

        else
        {

            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());

            if (operation == "+")
                Console.WriteLine("sum is " + (num1 + num2));
            else if (operation == "-")
                Console.WriteLine("sum is " + (num1 - num2));
            else if (operation == "*")
                Console.WriteLine("sum is " + (num1 * num2));
            else if (operation == "/")
            {
                if (num2 != 0)
                    Console.WriteLine("sum is " + num1 / (double)num2);
                else
                    Console.WriteLine("Error: Divison by zero is not allowed");

            }
            Console.WriteLine(" The first number is {0}, The second number is {1},", num1, num2);

        }
    }
}