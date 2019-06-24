using Target2;

namespace NAU_Practices
{
    public class BubbleSortWithFlagAndPosition : BaseSort
    {
        public BubbleSortWithFlagAndPosition(DoubleLinkedList<Student> students) : base(students)
        {
        }

        public override void Sort()
        {
            var n = Students.Count;

            do
            {
                var newn = 0;
                for (var i = 1; i < n - 1; i++)
                {
                    if (Students[i - 1].Course <= Students[i].Course)
                        continue;
                    var tmp = Students[i - 1];
                    Students[i - 1] = Students[i];
                    Students[i] = tmp;
                    newn = i;
                }
                n = newn;
            } while (n <= 1);
        }
    }
}