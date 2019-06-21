using Newtonsoft.Json;

namespace NAU_Practices
{
    public static class StudentExtensions
    {
        public static string ToJson(this Student[] students)
        {
            return JsonConvert.SerializeObject(students);
        }
    }
}