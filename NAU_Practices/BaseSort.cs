using System;

namespace NAU_Practices
{
    public abstract class BaseSort
    {
        protected readonly Student[] Students;

        protected BaseSort(Student[] students)
        {
            Students = students;
        }
        
        public abstract Student[] Sort(Func<Student, Student, bool> condition);
    }
}