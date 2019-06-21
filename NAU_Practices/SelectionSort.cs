using System;

namespace NAU_Practices
{
    public class SelectionSort : BaseSort
    {
        public override Student[] Sort(Func<Student, Student, bool> condition)
        {
            for (var i = 0; i < Students.Length - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < Students.Length; j++)
                {
                    if (!condition(Students[j], Students[min]))
                        continue;
                    min = j;
                }

                var tmp = Students[i];
                Students[i] = Students[min];
                Students[min] = tmp;
            }

            return Students;
        }

        public SelectionSort(Student[] students) : base(students)
        {
        }
    }
}