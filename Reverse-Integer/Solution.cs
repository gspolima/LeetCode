using System;
using System.Collections.Generic;

namespace Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {
            var numberString = x.ToString();
            var array = numberString.ToCharArray();
            var reversed = new Stack<string>(array.Length);
            var result = "";
            var invert = false;

            foreach (var @char in array)
            {
                if (@char == '-')
                {
                    invert = true;
                    continue;
                }
                reversed.Push(@char.ToString());
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
    }
}