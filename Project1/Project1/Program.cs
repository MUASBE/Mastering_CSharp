using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {

        public static int ReadFromUser()
        {
            while (true) 
            {
                Console.Write("Enter the number of students: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numberOfStudents) && numberOfStudents > 0)
                {
                    return numberOfStudents;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            } 
        }
        public static int ReadGrades(int i)
        {
            while (true)
            {
                Console.Write($"Enter grade {i}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int grade) && grade > 0)
                {
                    return grade;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("==================================================================================================");
            Console.WriteLine("\t\t\t\tWelcome to grading system");
            Console.WriteLine("==================================================================================================");

            List<clsStudent> students = new List<clsStudent>();

            int NumberOfStudents = ReadFromUser();

            for(int i = 1; i <= NumberOfStudents; i++ )
            {
                Console.WriteLine($"\nEnter Student {i} name: ");
                string name = Console.ReadLine();

                clsStudent student = new clsStudent(name);
                List<float> grades = new List<float>();

                Console.WriteLine($"Enter 5 grades for {name}: ");
                for(int j = 1; j<= 5; j++)
                {
                    grades.Add(ReadGrades(j));
                }
                student.Grades = grades;
                students.Add(student);

            }

            clsGradingSystem.StudentsGradesInfo(students, (grades) =>
            {
                if (grades.Count == 0) return 0; // To avoid division by zero
                return grades.Sum() / grades.Count();
            }, (student, Average, isPassed) => {
                
                string status = isPassed ? "Passed" : "Failed";
                Console.WriteLine($"Student: {student.Name}, Average Grade: {Average}, Status: {status}");
            }, (Average) => Average >= 30
            );
        }
    }
}
