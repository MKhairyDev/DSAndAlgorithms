using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public class TimeConvertsionProblem
    {
        /// <summary>
        /*
         Given a time in -hour AM/PM format, convert it to military (24-hour) time.

Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock. Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.

Function Description

Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

timeConversion has the following parameter(s):

s: a string representing time in  hour format
Input Format

A single string  containing a time in -hour clock format (i.e.:  or ), where  and .

Constraints

All input times are valid
Output Format

Convert and print the given time in -hour format, where .

Sample Input 0

07:05:45PM
Sample Output 0

19:05:45
         */
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string TimeConversion(string s)
        {
            /*
             * Write your code here.
             */
            int hour = int.Parse(s.Substring(0, 2));
            int minute = int.Parse(s.Substring(3, 2));
            int second = int.Parse(s.Substring(6, 2));
            String meridiem = s.Substring(8, 2);

            hour += ((meridiem==("PM") && hour != 12) ? 12 : 0);//Performs conversion based on current meridiem
            hour -= ((meridiem==("AM") && hour == 12) ? 12 : 0);

            string newStr= hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");
            return newStr;
        }
        public static void Run()
        {
            var res = TimeConversion("07:05:45PM");
            var res2 = TimeConversion("12:00:00AM");
            var re3 = TimeConversion("12:00:00PM");
        }
        //Scanner input = new Scanner(System.in);
        //String time = input.nextLine();

    }
}
