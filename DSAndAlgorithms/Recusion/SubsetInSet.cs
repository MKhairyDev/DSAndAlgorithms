using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    class SubsetInSet
    {
        public static List<List<int>> FindAllSubsetInSet(  List<int> originalList)
        {
            //O(2^n) complexity
            List<List<int>> IntegratedSubSet = new List<List<int>>();
            if (originalList.Count == 0)
            {
                IntegratedSubSet.Add(new List<int>());
                return IntegratedSubSet;
            }
            int currentItem = originalList[originalList.Count - 1];
            originalList.RemoveAt(originalList.Count - 1);
       
            var res=FindAllSubsetInSet( originalList);
            IntegratedSubSet.AddRange(res);
            foreach (var set in res)
            {
                var subList = new List<int>();
                subList.AddRange(set);
                subList.Add(currentItem);
                IntegratedSubSet.Add(subList);
            }
            return IntegratedSubSet;
      
        }
    }
}
