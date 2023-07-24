using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCulculator
{
    internal class Program
    {
        //    static void Main(string[] args)
        //    {
        //        Console.Write("Enter num1 : ");
        //        int num1 = int.Parse(Console.ReadLine());

        //        Console.Write("Enter Operator : ");
        //        string oprator = Console.ReadLine();

        //        Console.Write(" Enter num2 : ");
        //        int num2 = int.Parse(Console.ReadLine());

        //        if (oprator == "+")
        //        {
        //            Console.WriteLine("Answer is :  " + num1 + num2);
        //        }
        //        else if (oprator == "-")
        //        {
        //            Console.WriteLine("Answer is : " + (num1 - num2));
        //        }
        //        else if (oprator == "*")
        //        {
        //            Console.WriteLine("Answer is : " + num1 * num2);
        //        }

        //        else if (oprator == "/")
        //        {
        //            Console.WriteLine("Answer is: " + num1 / num2);
        //        }

        //        else if (oprator == "%")
        //        {
        //            Console.WriteLine("Answer is : " + num1 % num2);
        //        }
        //        else
        //        {
        //            Console.WriteLine("invalid operator ");
        //        }
        //            Console.ReadLine();

        //    }


        //CULCULATOR WITH SWICH ==============================

        static void Main(string[] args)
        {
            Console.WriteLine("colculator");
            Console.WriteLine("=========================");
            Console.Write("Enter a number : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1/2/3/4): ");
            int choice = int.Parse(Console.ReadLine());
            double result = 0;

            switch (choice)
            {

                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    result = num1 / num2;
                    break;


            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }

}