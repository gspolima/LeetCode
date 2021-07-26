using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(int x) {
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

            var reversedX = Int32.Parse(reversedString);

            return reversedX == x ? true : false;
        }
    }
}