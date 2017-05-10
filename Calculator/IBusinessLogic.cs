using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IBusinessLogic
    {
        int AddNumbers(int number1, int number2);
        int SubtractNumbers(int number1, int number2);
        int MultiplyNumbers(int number1, int number2);
        int DivideNumbers(int number1, int number2);

    }
}
