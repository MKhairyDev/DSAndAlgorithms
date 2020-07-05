using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms
{
   public static class Palindrome
    {
        public static bool IsPalindrome(string testString)
        {
            testString = testString.ToLower();
            int index = 0;
            int lastIndex = testString.Length - 1;
            while (index<lastIndex)
            {
                char firstChar = testString[index];
                char lastChar = testString[lastIndex];
                while(firstChar==' ')
                {
                    index++;
                    firstChar=testString[index];
                }
                while (lastChar == ' ')
                {
                    lastIndex--;
                    lastChar = testString[index];
                }
                if(firstChar!=lastChar)
                {
                    return false;
                }
                index++;
                lastIndex--;
            }
            return true;
        }

    }
}
