using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class NegativeNotAllowedException: Exception
    {
        public NegativeNotAllowedException(string msg):base(msg)
        {

        }
    }
}
