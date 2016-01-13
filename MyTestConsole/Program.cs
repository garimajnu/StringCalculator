using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var expression = "//;\n1,2";

            for (int i = 0; i < expression.Length; i++)
            {
                Console.WriteLine(expression[i]);
            }
        }
    }
}
