namespace GA_ClassInstanceMethods
{/// David Abarca <summary>
/// 1/30/2024
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 5 grades ranging betweeen 0 and 100
            List<int> DavidGrades = new List<int> { 85, 92, 78, 90, 88 };

            // Create a new instance of the Student class with the name "David" and the grades list
            Student DavidStudent = new Student("David", DavidGrades);

            DavidStudent.AddGrade(78);
            DavidStudent.AddGrade(200);
            DavidStudent.AddGrade(-130);

            DavidStudent.DisplayAllGrades();
            DavidStudent.GetGrade();
            DavidStudent.DisplayStudentInfo();

            List<Student> randomStudents = GenerateRandomStudents();
            randomStudents.Add(DavidStudent);
            foreach (Student student in randomStudents)
            {
                student.DisplayStudentInfo();

            }

        }

        static List<Student> GenerateRandomStudents()
        {
            List<Student> students = new List<Student>();
            Random random = new Random();
            for (int i = 1;i <=5; i++)
            {
                Student student = new Student($"Student{i}");
                for (int j = 0; j < 5; j++)
                {
                    student.ExamScores.Add(random.Next(0, 101));

                }
                students.Add(student);

            }

            return students;


        }


    }
}