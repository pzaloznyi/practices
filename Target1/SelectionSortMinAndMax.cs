using Target2;

namespace NAU_Practices
{
    public class SelectionSortMinAndMax : BaseSort
    {
        public SelectionSortMinAndMax(DoubleLinkedList<Student> students) : base(students)
        {
        }

        public override void Sort()
        {
            var length = Students.Count;
            for (int i = 1; i <= length / 2; i++)
            {
                var min = i;
                var max = length - i;
                if (Students[min].Course > Students[max].Course)
                {
                    var tmp = Students[min];
                    Students[min] = Students[max];
                    Students[max] = tmp;
                }
            }
        }
    }
}