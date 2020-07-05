using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
    public static class BreakDocumentIntoChunk
    {
        public static List<string> Chunkify(string document, char delimiter, int paragraphLength)
        {
            if (document == null)
                return null;
            List<string> chunkList = new List<string>();
            string currentChunk = "";
            List<string> docSpilitList = document.Split(delimiter).ToList();
            for (int i = 0; i < docSpilitList.Count; i++)
            {
                var currentItem = docSpilitList[i];
                if (currentChunk.Length + currentItem.Length > paragraphLength)
                {
                    if (currentItem.Length > 0)
                    {
                        chunkList.Add(currentChunk);
                        currentChunk = "";
                    }
                    
                }
                if (currentItem.Length > paragraphLength)
                {
                    if (currentChunk.Length > 0)
                    {
                        chunkList.Add(currentChunk);
                        currentChunk = "";
                    }
                    chunkList.Add(currentItem + delimiter);
                    continue;
                }
                currentChunk += currentItem + delimiter;
            }

                if (currentChunk.Length > 0)
                {
                    chunkList.Add(currentChunk);
                }
            
            return chunkList;
        }
    }
}
