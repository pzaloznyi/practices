namespace NAU_Practices
{
    public class Student
    {
        public Student(string name, int course, bool hasScholarship)
        {
            Name = name;
            Course = course;
            HasScholarship = hasScholarship;
        }
        
        public string Name { get; set; }
        public int Course { get; set; }
        public bool HasScholarship { get; set; }
    }
}