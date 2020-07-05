using DSAndAlgorithms.ArrayProblems;
using DSAndAlgorithms.BinaryTree;
using DSAndAlgorithms.BitManuiplationProblems;
using DSAndAlgorithms.LeetCode.Easy;
using DSAndAlgorithms.GeneralProblems;
using DSAndAlgorithms.Recusion;
using DSAndAlgorithms.StringProblems;
using System;
using System.Collections.Generic;
using DSAndAlgorithms.LeetCode.Medium;
using DSAndAlgorithms.Stack;
using DSAndAlgorithms.LinkedList;
using DSAndAlgorithms.QueueDS;
using DSAndAlgorithms.Dynamic_programming;
using DSAndAlgorithms.Sort_Search;

namespace DSAndAlgorithms
{
    class Program
    {
        public static int[] sortedArray = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };

        private static int[] listToSort= new int[] { 7,2,5,9,8 };
        static void Main(string[] args)
        {
            SortedMatrixSearch.Run();
            SparseSearch.Run();
            SearchInRotatedArray.Run();
            GroupAnagrams.Run();
            CombinationsOfNPairsParentheses.Run();
            PermutationWithDuplicates.Run();
            PermutationNoDuplicates.Run();
           
            var subsetList = new List<List<int>>();
            subsetList= SubsetInSet.FindAllSubsetInSet( new List<int> { 1, 2, 3 });
            ReverseLinkedList.Run();
            IsUniqueString.Run();
            StoneDivisionProblem.Run();
            Kangaroo.Run();
            AppleAndOrange.Run();
            AbbreviationProblem.Run();
            FibonacciModifiedProblem.Run();
            RecursiveDigitSum.Run();
            RangeSumOfBST.Run();
            GradingStudentsProblem.Run();
           // XorSequenceProblem.Run();
            CounterGameProblem.Run();
            MaximizingXORProblem.Run();
            LonelyIntegerProblem.Run();
            FlippingBitsProblem.Run();
            QueueUsingTwoStacksProblem.Run();
            GetNodeValue.Run();
            MergeTwoSortedLinkedLists.Run();
            Compare_Two_linked_lists.Run();
           
            DeleteNodeProblem.Run();
            ArrayManipulationProblem.Run();
            LeftRotationProblem.Run();
            HourGlass2D.Run();
            SimpleTextEditorProblem.Run();
            EqualStacksProblem.Run();
            MaximumElementProblem.Run();
            BinarySearchTreeInsertion.Run();
            TopViewProblem.Run();
            TimeConvertsionProblem.Run();
            BinaryTreePathsProblem.Run();
            IncreasingOrderSearchTree.Run();
            RemoveAllAdjacentDuplicatesInStringWithKLength.Run();
            RemoveAllAdjacentDuplicatesInString.Run();
            CheckStraightLineProblem.Run();
            HouseRobber.Run();
            UniquePathsProblem.Run();
            FirstUniqueCharacterInString.Run();
            BinaryTreeInorderTraversal.Run();
            DailyTemperaturesProblem.Run();
            CountingBitsproblem.Run();
            SortIntegersByTheNumberOf1BitsProblem.Run();
            HammingDistanceProblem.Run();
            RansomNoteProblem.Run();
            ConvertBinaryNumberInLinkedListToIntegerProblem.Run();
            NumberOfStepsToReduceNumberToZeroProblem.Run();
            JewelsAndStones.Run();
            ClimbingStairsProblem.Run();
            BestTimeToBuyAndSellStock.Run();
            MajorityElementProblem.Run();
            MoveZeroesProblem.Run();
            InvertBinaryTree.Run();
            SingleNumberProblem.Run();
            MaximumDepthInTrree.Run();
            MergeTwoBinaryTrees.Run();
            AddBinaryProblem.Run();
            PlusOneProblem.Run();
            LengthOfLastWordProblem.Run();
            KadaneAlgorithmForMaxSubArray.Run();
            KMPAlgorithm.Run();
            CountAndSayProblem.Run();
            SearchInsertPosition.Run();
            ImplementIndexOfString.Run();
            RemoveElement.Run();
            RemoveDuplicatesFromSortedArray.Run();
            MergeTwoSortedLists.Run();
            ValidParentheses.Run();
            LongestCommonPrefix.Run();
            RomanToInteger.Run();
            PalindromeNumber.Run();
            ReverseInteger.Run();
            TwoSumProblem.Run();
            AddOneToNumber.Run();
            MostAmountOfChange.Run();
            #region BinaryTree
            LeastCommonAncestor.Run();
            PrintAllPaths.Run();
            HasPathSum.Run();
            CheckIfBinaryTreeIsBinarySearchTree.Run();
            PrintAllNodesWithRangeInBinarySearchTree.Run();
            UniqueTreeStructureNumber.Run();
            MirrorTree.Run();
            #region BitManuiplation_GetNthNumber
            NumberOfStepsToReduceNumberToZeroProblem.Run();
            CountNumbersOf1InBit.Run();
            ReverseThebitsInInteger.Run();
            PrintBitsInInteger.Run();
            GetNthBit.Run();
            setNthBitTo1.Run();
            SetNthBitTo0.Run();
            #endregion
            MinimumtValueInTrree minValueInTree =new MinimumtValueInTrree();
            minValueInTree.Run();
            #endregion

            #region Recursion
            Chessboard chessboard = new Chessboard();
            chessboard.Run();
            RatPathToMaze ratPathToMaze = new RatPathToMaze();
            ratPathToMaze.Run();
            List<string> anagramList = new List<string>();
            anagramList= WordAnagram.GenerateWordAnagram("abc");
            Pixel[,] pixelList = new Pixel[3, 3] {
                { new Pixel(0, 0, "red"), new Pixel(0, 1, "green"), new Pixel(0, 2, "green") },
                { new Pixel(1, 0, "red"), new Pixel(1, 1, "green"), new Pixel(1, 2, "green") },
                { new Pixel(2, 0, "red"), new Pixel(2, 1, "green"), new Pixel(2, 2, "green") } };
            FillPaint.PaintFill(pixelList,1,2,"green","black");

            BinaryTreesAreTheSame.Run();
        
            #endregion

            #region General problems
            RotateArrayByKSpaces.Run();
         
            #region AddtwoNumbersReferencedByTheirDigits
            var addRes = AddtwoNumbersReferencedByTheirDigits.AddNumbers(new int[] { 1, 2, 7 }, new int[] { 9, 4 });
            #endregion

            #region RunLengthEncoding
            var encodedStr = RunLengthEncoding.Encode("aabbbbc");
            var decodedStr = RunLengthEncoding.Decode(encodedStr);
            #endregion

            #region BreakDocumentIntoChunk
            var chunkRes =  BreakDocumentIntoChunk.Chunkify("ab:dd:ddfcct:aab:cccc", ':', 5);
            #endregion

            #region GameOfLife
            var gameRes = GameOfLife.GetNextInteration(new int[3, 3] { { 1, 0, 0 }, { 0, 1, 1 }, { 1, 0, 0 } });
            #endregion.

            #endregion


            #region InsertionSort
            InsertionSort.insertionSort(listToSort);
            #endregion

            #region BinarySearch
            Console.WriteLine(String.Format("%s is present at index: %s",30, BinarySearch.binarySearch(sortedArray, 30, 0, sortedArray.Length - 1)));
            Console.WriteLine(String.Format("%s is present at index: %s",4, BinarySearch.binarySearch(sortedArray, 4, 0, sortedArray.Length - 1)));
            Console.WriteLine(String.Format("%s is present at index: %s",15, BinarySearch.binarySearch(sortedArray, 15, 0, sortedArray.Length - 1)));
            #endregion


            #region MergeSort
            MergeSort.print(listToSort);
            MergeSort.mergeSort(listToSort);
            #endregion


            #region QuickSort
            QuickSort.print(listToSort);
            QuickSort.quickSort(listToSort, 0, listToSort.Length - 1);
            QuickSort.print(listToSort);
            #endregion

        }
    }
}
