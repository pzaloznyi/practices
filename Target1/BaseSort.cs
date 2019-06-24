using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Target2;

namespace NAU_Practices
{
    public abstract class BaseSort
    {
        protected readonly IList<Student> Students;

        protected BaseSort(DoubleLinkedList<Student> students)
        {
            Students = students as IList<Student>;
        }

        public abstract void Sort();

        public int[] Find(Func<FindStudent, bool> condition)
        {
            Console.WriteLine(JsonConvert.SerializeObject(Students));
            return Students.Select((s, i) => new FindStudent(s, i)).Where(condition).Select(f => f.Index).ToArray();
        }
    }

    public class FindStudent
    {
        public FindStudent(Student student, int index)
        {
            Student = student;
            Index = index;
        }

        public int Index { get; set; }
        public Student Student { get; set; }
    }
}