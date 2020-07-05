using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/grading/problem
    /// </summary>
    public class GradingStudentsProblem
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    res.Add(grades[i]);
                    continue;
                }
                var roundRes = Math.Ceiling((double)grades[i] / 5);
                int maxMultibleBy5 = (int)(roundRes * 5);
                int subRes = maxMultibleBy5 - grades[i];
                if (subRes < 3)
                {
                    res.Add(maxMultibleBy5);
                }
                else
                {
                    res.Add(grades[i]);
                }
            }
            return res;
        }
        public static void Run()
        {
            var res = GradingStudents(new List<int> { 73, 67, 38, 33 });
        }
    }
}
