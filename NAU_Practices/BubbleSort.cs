using System;

namespace NAU_Practices
{
    internal class BubbleSort : BaseSort
    {
        public override Student[] Sort(Func<Student, Student, bool> condition)
        {
            for (var k = Students.Length - 1; k > 0; k--)
            for (var i = 0; i < k; i++)
                if (condition(Students[i], Students[i + 1]))
                {
                    var buf = Students[i];
                    Students[i] = Students[i + 1];
                    Students[i + 1] = buf;
                }

            return Students;
        }

        public BubbleSort(Student[] students) : base(students)
        {
        }
    }
}