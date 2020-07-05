using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
   public class RunLengthEncoding
    {
        public static string Encode(string originalString)
        {
            int currentIndex = 0;
            StringBuilder encodedString = new StringBuilder();
            while(currentIndex< originalString.Length)
            {
             
                char currChar = originalString[currentIndex];
                int compareIndex = currentIndex;
                int num = 0;
                while (compareIndex < originalString.Length && currChar == originalString[compareIndex])
                {
                    compareIndex++;
                    num++;
                }
                encodedString.Append(num);
                encodedString.Append(currChar);
                currentIndex = compareIndex;
            }
            return encodedString.ToString();
        }
        public static string Decode(string encodedString)
        {
            int numStartIndex = 0;
            int numEndIndex = 1;
            StringBuilder decodedString = new StringBuilder();
            while (numEndIndex < encodedString.Length)
            {
                while (char.IsDigit(encodedString[numEndIndex]))
                {
                    numEndIndex++;
                }
                int charIndex = numEndIndex;
              string numString=  encodedString.Substring(numStartIndex, numEndIndex- numStartIndex);
                    int num = int.Parse(numString);
                for (int i = 0; i < num; i++)
                {
                    decodedString.Append(encodedString[charIndex]);
                }
                numStartIndex = charIndex+1;
                numEndIndex = numStartIndex + 1;
                
            }
            return decodedString.ToString();
        }
    }
}
