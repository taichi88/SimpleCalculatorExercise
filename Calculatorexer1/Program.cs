// See https://aka.ms/new-console-template for more information





class Program
{
    static void Main()
    {
        Console.WriteLine("\tCalculator has started ");
        bool continue1 = true;
        while (continue1)

        {
            Console.WriteLine("\tEnter the one of the Operation Symbol \n\tSum:\t+ \n\tSub:\t- \n\tMult:\t* \n\tDev:\t/ \n\tRoot:\t// \n\tDegree:\t** ");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "//" && operation != "**")

            {
                Console.WriteLine("Error: invalid operations. ");
            }


            else if (operation == "//" || operation == "**")
            {
                if (operation == "//")
                {
                    Console.WriteLine("\tEnter The Number to make Square Root");
                    int num1 = int.Parse(Console.ReadLine());
                    double squareRoot = Math.Sqrt(num1);
                    Console.WriteLine("\tRoot of the number you entered is " + squareRoot);
                }
                else
                {
                    Console.WriteLine("\tEnter The Number to make degree  ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\tEnter degree for the number ");
                    int degree = int.Parse(Console.ReadLine());

                    double numDegree = Math.Pow(num1, degree);
                    Console.WriteLine(degree + "\tdegree of the number you entered is " + numDegree);
                }
                Console.WriteLine("\tIf you would like to continue press 'y' ");
                string askUser = Console.ReadLine();
                { if (askUser != "y")
                {

                    continue1 = false;
                }
                Console.Clear();
            }
        }
                  else
            {
                Console.WriteLine("\tEnter First Number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\tEnter Second Number");
                int num2 = int.Parse(Console.ReadLine());

                if (operation == "+")
                    Console.WriteLine("sum is " + (num1 + num2));
                else if (operation == "-")
                    Console.WriteLine("sub is " + (num1 - num2));
                else if (operation == "*")
                    Console.WriteLine("mult is " + (num1 * num2));                             
                else if (operation == "/")
                        {
                            if (num2 != 0)
                                Console.WriteLine("\tdev is " + num1 / (double)num2);
                            else
                                Console.WriteLine("\tError: Divison by zero is not allowed");
                        }
                Console.WriteLine("\tThe first number is {0}, The second number is {1},", num1, num2);
                Console.WriteLine("\tIf you would like to continue press 'y' ");
                string askUser = Console.ReadLine();
                if (askUser != "y")
                {             
                    continue1 = false;
                }
                Console.Clear();
            }
        }
        Console.Clear();
        Console.WriteLine("\tThank you for using Calculator. See you next time");
    }
}