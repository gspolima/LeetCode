using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(int x) {
            if (x < 0)
                return false;

            try
            {
                var charArray = x.ToString().ToCharArray();
                var stack = new Stack<char>();

                foreach (var number in charArray)
                {
                    stack.Push(number);
                }

                var reversedCharArray = stack.ToArray<char>();
                var reversedString = "";

                foreach (var item in reversedCharArray)
                {
                    reversedString += item;
                }

                return Int32.Parse(reversedString) == x ? true : false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
    }
}