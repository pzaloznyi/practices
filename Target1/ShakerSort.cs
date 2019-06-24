using Target2;

namespace NAU_Practices
{
    public class ShakerSort : BaseSort
    {
        public ShakerSort(DoubleLinkedList<Student> students) : base(students)
        {
        }

        public override void Sort()
        {
            int left = 0,
                right = Students.Count - 1;

            while (left < right)
            {
                for (var i = left; i < right; i++)
                {
                    if (Students[i].Course > Students[i + 1].Course)
                        Swap(i, i + 1);
                }
                right--;

                for (var i = right; i > left; i--)
                {
                    if (Students[i - 1].Course > Students[i].Course)
                        Swap(i - 1, i);
                }
                left++;
            }
        }
        
        private void Swap(int i, int j)
        {
            var tmp = Students[i];
            Students[i] = Students[j];
            Students[j] = tmp;
        }
    }
}