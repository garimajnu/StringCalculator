using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class ArguementException: Exception
    {
        public ArguementException(string msg):base(msg)
        {

        }
    }
}
