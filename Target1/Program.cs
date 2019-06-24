using System;
using System.Collections.Generic;
using Target2;

namespace NAU_Practices
{
    internal class Program
    {
        private static DoubleLinkedList<Student> InitStudents()
        {
            var list = new DoubleLinkedList<Student>();
            list.AddFirst(new Student("AA", 1, false));
            list.AddFirst(new Student("AE", 2, false));
            list.AddFirst(new Student("AI", 5, false));
            list.AddFirst(new Student("AH", 4, true));
            list.AddFirst(new Student("AF", 3, true));
            list.Add(new Student("AG", 4, false));
            list.Add(new Student("AB", 1, true));
            list.Add(new Student("AD", 2, true));
            list.Add(new Student("AJ", 5, true));
            list.Add(new Student("AC", 2, false));
            return list;
        }

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