using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Sort_Search
{
    /*
     Sparse Search: Given a sorted array of strings that is interspersed with empty strings, write a
method to find the location of a given string.
EXAMPLE
Input: ball, {"at","","","","abc","",""}
Output: 4

     */
    class SparseSearch
    {
       static int Search(string[] strings, string str)
        {
            if (strings == null || str == null || str == "")
            {

                return -1;
            }

           return SearchHelper(strings, str, 0, strings.Length - 1);
        }
        static int SearchHelper(string[] strArr, string str, int first, int last)
        {
            int mid = (first + last) / 2;
           if(string.IsNullOrWhiteSpace( strArr[mid]))
            {
                int right = mid + 1;
                int left = mid - 1;
                while(true)
                {
                    if(left<first&&right>last)
                    {
                        return -1;
                    }
                    else if(right<=last&& !string.IsNullOrWhiteSpace(strArr[right]))
                    {
                        mid = right;
                        break;
                    }
                    else if (left > first && !string.IsNullOrWhiteSpace(strArr[left]))
                    {
                        mid = left;
                        break;
                    }
                    right++;
                    left--;
                }
            }
            if (str.Equals(strArr[mid]))
                return mid;
           else if(strArr[mid].CompareTo(str)<0)
            {
              return SearchHelper(strArr, str, mid + 1, last);
            }
            else 
            {
                return SearchHelper(strArr, str, first, mid-1);
            }
     

        }
        public static void Run()
        {
         var res=   Search(new string[] { "abc", "", "", "", "def", "", "" },"def");
        }
    }
}
