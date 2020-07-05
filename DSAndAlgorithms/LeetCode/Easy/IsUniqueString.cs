using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public class IsUniqueString
    {
        public static bool IsUnique(string s)
        {
            int checker = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i] - 'a';
                var res = 1 << val;
                if((checker&res)>0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }
        public static void Run()
        {
            var res = IsUnique("test");
            var res2 = IsUnique("unique");
        }
    }
}
