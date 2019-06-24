using Target2;

namespace NAU_Practices
{
    public class SelectionSortMinOrMax : BaseSort
    {
        public SelectionSortMinOrMax(DoubleLinkedList<Student> students) : base(students)
        {
        }

        public override void Sort()
        {
            var length = Students.Count;
            for (var i = 0; i < length - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < length; j++)
                {
                    if (Students[j].Course < Students[min].Course)
                    {
                        min = j;
                    }
                }

                if (min == i) continue;
                var tmp = Students[i];
                Students[i] = Students[min];
                Students[min] = tmp;
            }
        }
    }
}