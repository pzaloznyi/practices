using System;
using System.Collections.Generic;

namespace NAU_Practices
{
    internal class Program
    {
        private static Student[] InitStudents() => new[]
            {
                new Student("AA", 1, false),
                new Student("AE", 2, false),
                new Student("AI", 5, false),
                new Student("AH", 4, true),
                new Student("AF", 3, true),
                new Student("AG", 4, false),
                new Student("AB", 1, true),
                new Student("AD", 2, true),
                new Student("AJ", 5, true),
                new Student("AC", 2, false),
            };

        public static void Main()
        {
            Console.WriteLine(SortStudents(AlgorithmType.SelectionSort, (s1, s2) => !s1.HasScholarship && s1.Course == 2).ToJson());
            Console.WriteLine(SortStudents(AlgorithmType.BubbleSort, (s1, s2) => !s2.HasScholarship && s2.Course == 2).ToJson());
        }

        private static Student[] SortStudents(AlgorithmType algorithmType, Func<Student, Student, bool> condition)
        {
            return Algorithms[algorithmType].Sort(condition);
        }

        static readonly Dictionary<AlgorithmType, BaseSort> Algorithms =
            new Dictionary<AlgorithmType, BaseSort>
        {
            [AlgorithmType.SelectionSort] = new SelectionSort(InitStudents()), 
            [AlgorithmType.BubbleSort] = new BubbleSort(InitStudents()), 
        };
    }

    public enum AlgorithmType
    {
        SelectionSort = 1,
        BubbleSort = 3
    }

}