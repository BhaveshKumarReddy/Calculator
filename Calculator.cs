using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Subtract(int first, int second)
        {
            return Sub.sub(first, second);
        }
        public int Addition(int first,int second)
        {
            return Add.add(first, second);
        }

        public int Division(int first, int second)
        {
            return Div.div(first, second);
        }

        public int Multiplication(int first, int second)
        {
            return Multiply.mul(first, second);
        }

    }
}
