namespace NAU_Practices
{
    public class SelectionSortMinOrMax : BaseSort
    {
        public override void Sort()
        {
            var length = Students.Length;
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

        public SelectionSortMinOrMax(Student[] students) : base(students)
        {
        }
    }
}