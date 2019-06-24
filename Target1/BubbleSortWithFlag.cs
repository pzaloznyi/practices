using Target2;

namespace NAU_Practices
{
    public class BubbleSortWithFlag : BaseSort
    {
        public BubbleSortWithFlag(DoubleLinkedList<Student> students) : base(students)
        {
        }

        public override void Sort()
        {
            var length = Students.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (var i = 1; i < length - 1; i++)
                {
                    if (Students[i - 1].Course > Students[i].Course)
                    {
                        var tmp = Students[i - 1];
                        Students[i - 1] = Students[i];
                        Students[i] = tmp;
                        swapped = true;
                    }
                }

                length--;
            } while (!swapped);
        }
    }
}