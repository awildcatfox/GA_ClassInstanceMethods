using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ClassInstanceMethods
{
    public class Student
    {
        // properties
        public string Name { get; set; }
        public List<int> ExamScores { get; private set; }

        // Constructor to initialize the student with a nmae and a list of exam scores
        public Student(string name)
        {
            Name = name;
            ExamScores = new List<int>();

        }

        // Constructor that takes in a list of grades
        public Student(string name, List<int> examScores)
        {
            Name = name;
            ExamScores = examScores;


        }

       

        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                ExamScores.Add(grade);
                Console.WriteLine($"Added grade {grade} for {Name}");
            }
            else
            {
                Console.WriteLine($"Invalid grade: {grade}. Grade ,must be between 0 and 100.");

            }


        }

        private char GetLetterGrade(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >=80)
            {

                return 'B';

            }
            else if (score >= 70)
            {

                return 'C';

            }
            else if (score >= 60)
            {

                return 'D';

            }
            else
            {

                return 'F';

            }




        }

        public void DisplayAllGrades()
        {

            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0; i < ExamScores.Count; i++)
            {
                char letterGrade = GetLetterGrade(ExamScores[i]);
                Console.WriteLine($"Exam {i + 1}: {letterGrade} ({ExamScores[i]})");

            }

        }

        public double CalculateAverageScore()
        {

            if (ExamScores.Count == 0)
            {
                return 0;

            }

            int totalScore = 0;
            foreach (int score in ExamScores)
            {
                totalScore += score;

            }
            return (double)totalScore / ExamScores.Count;

        }

        public char GetGrade()
        {

            double averageScore = CalculateAverageScore();
            int roundedAverageScore = (int)Math.Round(averageScore);
            return GetLetterGrade(roundedAverageScore);

            
        }

        public void DisplayStudentInfo()
        {
            double averageScore = CalculateAverageScore();
            char grade = GetGrade();
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Average Score: {averageScore:F2}");
            Console.WriteLine($"Grade: {grade}");
        }


    }
}
