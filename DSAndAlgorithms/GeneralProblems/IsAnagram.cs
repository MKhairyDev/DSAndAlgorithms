using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
   public class IsAnagram
    {
        public bool Check(string s, string t)
        {
            var str1Length = s.Length;
            var str2Length = t.Length;
            if (str1Length != str2Length)
                return false;
          s=  String.Concat(s.OrderBy(c => c));
            t = String.Concat(t.OrderBy(c => c));
            for (int i = 0; i < str1Length; i++)
            {
                if(s[i]!= t[i])
                    return false;
            }
            return true;
               
        }
        public bool Check2(string s, string t)
        {
           var arrS =  s.ToArray();
            Array.Sort(arrS);
            var arrT = t.ToArray();
            Array.Sort(arrT);
            var arr1Length = arrS.Length;
            var arr2Length = arrT.Length;
            if (arr1Length != arr2Length)
                return false;
            
            for (int i = 0; i < arr1Length; i++)
            {
                if(arrS[i]!= arrT[i])
                    return false;
            }
            return true;
               
        }

        public bool Check3(string s, string t)
        {
            var arrS = convertToSortedArraye(s);
            var arrT = convertToSortedArraye(t);
            var arr1Length = arrS.Length;
            var arr2Length = arrT.Length;
            if (arr1Length != arr2Length)
                return false;


                if (arrS != arrT)
                    return false;
            
            return true;

        }
        char[] convertToSortedArraye(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return characters;
        }
    }
}
