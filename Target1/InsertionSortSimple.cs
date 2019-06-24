using Target2;

namespace NAU_Practices
{
    public class InsertionSortSimple : BaseSort
    {
        public InsertionSortSimple(DoubleLinkedList<Student> students) : base(students)
        {
        }

        public override void Sort()
        {
            for (var i = 1; i < Students.Count; i++)
            {
                var cur = Students[i];
                var j = i;
                while (j > 0 && cur.Course < Students[j - 1].Course)
                {
                    Students[j] = Students[j - 1];
                    j--;
                }
                Students[j] = cur;
            }
        }
    }
}