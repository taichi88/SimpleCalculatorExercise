// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator has started ");
        bool continue1 = true;
        while (continue1)
                
        {
            
            Console.WriteLine("Enter the one of the Operation Symbol \n+ \n- \n* \n/ ");
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
                Console.WriteLine("If you would like to continue press 'y' ");
                string askUser = Console.ReadLine();
                if (askUser != "y")
                {
                    
                    continue1 = false;
                }
                Console.Clear();


            }
        }
        Console.Clear();
        Console.WriteLine("Thank you for using Calculator. See you next time");
    }
}