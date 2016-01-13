using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class AirthmeticStringCalculator
    {
        public int Add(string input)
        {
            if (input == string.Empty)
                return 0;
            string[] numbers;
            if (input.StartsWith("//"))
            {
                if(input.Length < 4 || input[3] != '\n')
                {
                    throw new  ArgumentException("Input expression is not in correct format");
                }
                char delimiter = input[2];
                var numberString = input.Substring(4, input.Length - 4);
                numbers = numberString.Split(new char[] { delimiter }, StringSplitOptions.None);
            }
            else
            {
                numbers = input.Split(new char[] { ',', '\n' });
            }
            return Calculate(numbers);

        }

        private int Calculate(string[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                if (int.Parse(item) < 0)
                    throw new NegativeNotAllowedException("Negative numbers are not allowe in the input string");
                result += int.Parse(item);
            }
            return result;

        }
    }
}
