using System;
using System.Collections.Generic;

namespace Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {
            try
            {
                var minValue = -(Math.Pow(2, 31));
                var maxValue = Math.Pow(2, 31);
                var invert = false;

                if(x < 0)
                    invert = true;

                var absoluteNumber = Math.Abs(x).ToString();
                var array = absoluteNumber.ToCharArray();
                var reversed = new Stack<char>(array.Length);
                var result = "";

                foreach (var @char in array)
                {
                    reversed.Push(@char);
                }

                foreach (var number in reversed)
                {
                    result += number;
                }

                var numericResult = int.Parse(result);

                if (invert)
                    numericResult *= -1;

                return numericResult;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}