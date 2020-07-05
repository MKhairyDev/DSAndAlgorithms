using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    /*
     Parens: Implement an algorithm to print all valid (i.e., properly opened and closed) combinations
of n pairs of parentheses.
EXAMPLE
Input: 3
Output: (( () ) ) , ( () () ) , ( () ) () , () ( () ) , () () ()

     */
    public class CombinationsOfNPairsParentheses
    {
        /*
         * We can avoid this duplicate string issue by building the string from scratch. Under this approach, we add
left and right parens, as long as our expression stays valid.

         */
        static List<string> GenerateParens(int count)
        {
            char[] str = new char[count * 2];
            List<string> res = new List<string>();
            GenerateParensHelper(res, count, count, str, 0);
            return res;
        }
    static void  GenerateParensHelper(List<string>result, int leftParen,int rightParen,char[]charArr,int index)
        {
            if(leftParen<0||rightParen< leftParen)
            {
                return ;
            }
            if(leftParen==0&&rightParen==0)
            {
                result.Add(new string(charArr));
            }
            else
            {
                charArr[index] = '(';
                 GenerateParensHelper(result, leftParen - 1, rightParen, charArr, index + 1);
                charArr[index] = ')';
                GenerateParensHelper(result, leftParen, rightParen - 1, charArr, index + 1);
            }

        }
            /*
             in this approach we have some duplicate pairs listed. 
              we'll need to check for duplicate values before adding a string to our list.
             */
            static HashSet<string> GenerateParens2(int count)
        {
            HashSet<string> result = new HashSet<string>();
            if (count == 0)
            {
                result.Add("");
                return result;
            }
            var res = GenerateParens(count - 1);
            foreach (string s in res)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '(')
                    {
                        var before = s.Substring(0, j+1);
                        var after = s.Substring(j+1);
                        result.Add(before + "()" + after);
                    }
                }
                result.Add("()"+ s);
            }
            
            return result;

        }
        public static void Run()
        {
           var res=GenerateParens(3);
        }
    }
}
