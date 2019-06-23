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
            Print(AlgorithmType.SelectionSortMinOrMax);
            Print(AlgorithmType.SelectionSortMinAndMax);
            Print(AlgorithmType.BubbleSort);
            Print(AlgorithmType.BubbleSortWithFlag);
            Print(AlgorithmType.BubbleSortWithFlagAndPosition);
            Print(AlgorithmType.ShakerSort);
            Print(AlgorithmType.InsertionSortSimple);
        }

        static void Print(AlgorithmType type)
        {
            var sortAlgorithm = Algorithms[type];
            sortAlgorithm.Sort();
            
            Console.WriteLine(string.Join(", ", sortAlgorithm.Find(s => !s.Student.HasScholarship && s.Student.Course == 2)));
        }

        static readonly Dictionary<AlgorithmType, BaseSort> Algorithms =
            new Dictionary<AlgorithmType, BaseSort>
        {
            [AlgorithmType.SelectionSortMinOrMax] = new SelectionSortMinOrMax(InitStudents()), 
            [AlgorithmType.SelectionSortMinAndMax] = new SelectionSortMinAndMax(InitStudents()), 
            [AlgorithmType.BubbleSort] = new SelectionBubbleSort(InitStudents()),
            [AlgorithmType.BubbleSortWithFlag] = new BubbleSortWithFlag(InitStudents()),
            [AlgorithmType.BubbleSortWithFlagAndPosition] = new BubbleSortWithFlagAndPosition(InitStudents()),
            [AlgorithmType.ShakerSort] = new ShakerSort(InitStudents()),
            [AlgorithmType.InsertionSortSimple] = new InsertionSortSimple(InitStudents()),
        };
    }

    public enum AlgorithmType
    {
        SelectionSortMinOrMax = 1,
        SelectionSortMinAndMax = 2,
        BubbleSort = 3,
        BubbleSortWithFlag = 4,
        BubbleSortWithFlagAndPosition = 5,
        ShakerSort = 6,
        InsertionSortSimple = 7
    }

}