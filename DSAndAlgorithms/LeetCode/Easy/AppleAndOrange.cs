using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/apple-and-orange/problem
    /// </summary>
    class AppleAndOrange
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesCount = 0;
            int orangeCount = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                apples[i] = apples[i] + a;
                if(s<= apples[i] && apples[i] <= t)
                {
                    applesCount++;
                }
            }
            Console.WriteLine(applesCount);
            for (int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = oranges[i] + b;
                if (s <= oranges[i]  && oranges[i] <= t)
                {
                    orangeCount++;
                }
            }
            Console.WriteLine(orangeCount);
        }
        public static void Run()
        {

      countApplesAndOranges(2, 3, 1, 5, new int[] { 2 }, new int[] { -2 });
            countApplesAndOranges(7,11,5,15,new int[] { -2,2,1},new int[] { 5,-6});
        }
    }
}
