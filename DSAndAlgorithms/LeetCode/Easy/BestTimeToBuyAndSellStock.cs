using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

Note that you cannot sell a stock before you buy one.

Example 1:

Input: [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
         Not 7-1 = 6, as selling price needs to be larger than buying price.
Example 2:

Input: [7,6,4,3,1]
Output: 0
Explanation: In this case, no transaction is done, i.e. max profit = 0.
     */
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /*
         Complexity Analysis

Time complexity : O(n). Only a single pass is needed.

Space complexity : O(1). Only two variables are used.
         */
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice =prices[i];
                   // maxProfit = 0;
                }
                else
                {
                    var currentprofit = prices[i] - minPrice;
                    if (maxProfit < currentprofit)
                    {
                        maxProfit = currentprofit;
                        
                    }
                }
                
            }
            return maxProfit;
        }
            /// <summary>
            /// Brute-Force O(n^2)
            /// </summary>
            /// <param name="prices"></param>
            /// <returns></returns>
            public static int MaxProfit2(int[] prices)
        {
            int maxProfit=0;
            int currentItem = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > currentItem)
                    continue;
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[i] > prices[j])
                        continue;
                    var currentprofit = prices[j] - prices[i];
                    if(maxProfit<currentprofit)
                    {
                        maxProfit = currentprofit;
                        currentItem = prices[i];
                    }
                }
            }
            return maxProfit;
        }
        public static void Run()
        {
            var res3 = MaxProfit(new int[] {2,4,1});
            var res = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            var res2 = MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }
    }
}
