namespace Data
{
    public class Student
    {
        // Guid will be same if it runs on 2 systems and they create a large number of acc in short time
        public Student() 
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public static class StudentList
    {
        public static List<Student> Students = new List<Student>();
    }
}
