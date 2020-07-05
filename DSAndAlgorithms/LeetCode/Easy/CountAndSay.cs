using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public  class CountAndSayProblem
    {
        /// <summary>
        /*
         The count-and-say sequence is the sequence of integers with the first five terms as following:

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.

Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence. You can do so recursively, in other words from the previous member read off the digits, counting the number of digits in groups of the same digit.

Note: Each term of the sequence of integers will be represented as a string.

 

Example 1:

Input: 1
Output: "1"
Explanation: This is the base case.
Example 2:

Input: 4
Output: "1211"
Explanation: For n = 3 the term was "21" in which we have two groups "2" and "1", "2" can be read as "12" which means frequency = 1 and value = 2, the same way "1" is read as "11", so the answer is the concatenation of "12" and "11" which is "1211". 
         */
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string CountAndSay(int n)
        {
            // Base cases 
            if (n == 1) return "1";
            if (n == 2) return "11";

            // Find n'th term by generating  
            // all terms from 3 to n-1.  
            // Every term is generated using 
            // previous term 

            // Initialize previous term 
            string str = "11";
            for (int i = 3; i <= n; i++)
            {
                // In below for loop, previous  
                // character is processed in  
                // current iteration. That is  
                // why a dummy character is  
                // added to make sure that loop 
                // runs one extra iteration. 
                str += '$';
                int len = str.Length;

                int cnt = 1; // Initialize count of 
                             // matching chars 
                string tmp = ""; // Initialize i'th  
                                 // term in series 
                char[] arr = str.ToCharArray();

                // Process previous term  
                // to find the next term 
                for (int j = 1; j < len; j++)
                {
                    // If current character 
                    // does't match 
                    if (arr[j] != arr[j - 1])
                    {
                        // Append count of  
                        // str[j-1] to temp 
                        tmp += cnt + 0;

                        // Append str[j-1] 
                        tmp += arr[j - 1];

                        // Reset count 
                        cnt = 1;
                    }

                    // If matches, then increment  
                    // count of matching characters 
                    else cnt++;
                }

                // Update str 
                str = tmp;
            }

            return str;
        }
        public static string CountAndSayRec(int n)
        {
            if (n == 2)
                return "11";
            StringBuilder newValue = new StringBuilder("");
            var res = CountAndSay(n - 1);
            int i = 0;
            for (int j = 1; j < res.Length; j++)
            {
                if (res[i] != res[j])
                {
                    newValue.Append("1" + res[i]);
                    if (j == res.Length - 1)
                    {
                        newValue.Append("1" + res[j]);
                    }
                    i++;
                }
                else
                {
                    newValue.Append(((j - i) + 1).ToString() + res[i]);
                    i = j;
                }
            }
            return newValue.ToString();

        }
        public static void Run()
        {
            var re = CountAndSay(3);
            var res2 = CountAndSay(5);
           
        }
    }
}
