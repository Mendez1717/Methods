using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Mikayla Anne Mendez!");
            int Num1, Num2, result;
            char option;
            Console.Write("Enter the first number:  ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second line:  ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform:  ");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("The sum of the Addition Operation is:  {0}", result);
                    break;
                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("The result from the Subtraction Operation is:  {0}", result);
                    break;
                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("The result from the Multiplication Operation is:  {0}", result);
                    break;
                case '4':
                    result = Num1 / Num2;
                    if (Num2 == 0)
                    {
                        Console.WriteLine("Zero cannot be divided");
                        break;
                    }
                    else if (Num2 > 0)
                    {
                        Console.WriteLine("The result from the Division Operation is:  {0}", result);
                        break;
                    }
                    break;
                    
                default:
                    Console.WriteLine("Invalid Option");
                    break;
                   
                        

            }
            Console.ReadLine();
        }
       

    }
}

