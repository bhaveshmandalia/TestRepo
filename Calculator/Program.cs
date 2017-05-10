using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLogic objLogic = new BusinessLogic();
            int output = 0, number1 = 0, number2 = 0;
            Console.WriteLine("Please choose one option :");
            Console.WriteLine("1. Addition :");
            Console.WriteLine("2. Subtraction :");
            Console.WriteLine("3. Multiplication :");
            Console.WriteLine("4. Division :");

            var operation = Console.ReadLine();

            Console.WriteLine("Enter Number 1 :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 :");
            number2 = Convert.ToInt32(Console.ReadLine());

            switch (Convert.ToInt32(operation))
            {
                case 1: output = objLogic.AddNumbers(number1, number2);
                    break;
                case 2:
                    output = objLogic.SubtractNumbers(number1, number2);
                    break;
                case 3:
                    output = objLogic.MultiplyNumbers(number1, number2);
                    break;
                case 4:
                    output = objLogic.DivideNumbers(number1, number2);
                    break;
            }

            Console.WriteLine("Final Output is  :{0}", output);
            Console.ReadLine();
        }
    }
}
