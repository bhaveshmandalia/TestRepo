using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BusinessLogic : IBusinessLogic
    {
        public int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int DivideNumbers(int number1, int number2)
        {
            return number1 / number2;
        }

        public int MultiplyNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        public int SubtractNumbers(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
