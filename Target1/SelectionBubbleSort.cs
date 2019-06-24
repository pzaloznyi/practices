namespace NAU_Practices
{
    internal class SelectionBubbleSort : BaseSort
    {
        public override void Sort()
        {
            for (var k = Students.Length - 1; k > 0; k--)
            for (var i = 0; i < k; i++)
                if (Students[i].Course > Students[i + 1].Course)
                {
                    var buf = Students[i];
                    Students[i] = Students[i + 1];
                    Students[i + 1] = buf;
                }
        }

        public SelectionBubbleSort(Student[] students) : base(students)
        {
        }
    }
}