using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Sort_Search
{
    /*
     Group Anagrams: Write a method to sort an array ot strings so that all tne anagrnms are next to
each other
     */
    public class GroupAnagrams
    {
        public static void SortGroupAnagram(string[] arr)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            foreach (var item in arr)
            {
                var s=SortAnagram(item);
                if(dic.ContainsKey(s))
                {
                    dic[s].Add( item);
                }
                else
                {
                    dic.Add(s, new List<string> { item });
                }
                int index = 0;
                foreach (var keyVal in dic)
                {
                    foreach (var anag in keyVal.Value)
                    {
                        arr[index] = anag;
                        index++;
                    }
                   
                }
            }
    
        }
        private static string SortAnagram(string s)
        {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
        /*
         This algorithm will take O(n log(n)) time.
       This may be the best we can do for a general sorting algorithm, but we don't actually need to fully sort the
       array. We only need to group the strings in the array by anagram.

         */
        public static void SortGroupAnagram2(string[]arr)
        {
            Array.Sort(arr, new GroupAnagramComparer());
        }
        public static void Run()
        {
            var arr = new string[] { "acre", "ert", "gre", "race", "care", "tre" };
            SortGroupAnagram(arr);
        }
    }
    public class GroupAnagramComparer:IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            return SortAnagram(s1).CompareTo(SortAnagram(s2));
        }

        private string SortAnagram(string s)
        {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}
