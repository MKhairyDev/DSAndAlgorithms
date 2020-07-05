
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
   public class WordAnagram
    {
        public static List<string> GenerateWordAnagram(string word)
        {
            //O(n!) complexity
            if (word.Length == 1)
            {
                List<string> potentialanagram = new List<string>();
                potentialanagram.Add(word);
                return potentialanagram;
            }
            List<string> anagramList = new List<string>();
            char currentChar = word[word.Length - 1];
            word = word.Remove(word.Length - 1);
            List<string> potentialanagramList = new List<string>();
            potentialanagramList = GenerateWordAnagram(word);
            InsertCharacterAtEveryIndex(potentialanagramList, currentChar, anagramList);

            return anagramList;

        }
        private static void InsertCharacterAtEveryIndex(List<string> potentialAnagramList, char currentChar, List<string> anagramList)
        {

            foreach (var currWord in potentialAnagramList)
            {
                for (int index = 0; index <= currWord.Length; index++)
                {
                    StringBuilder sb = new StringBuilder(currWord);
                    if (index < currWord.Length)
                        sb.Insert(index, currentChar.ToString());
                    else
                        sb.Append(currentChar);
                    anagramList.Add(sb.ToString());
                }
            }
        }
    }
}
