using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class clsGradingSystem
    {
        public static void StudentsGradesInfo(List<clsStudent>students, Func<List<float>, float> calculateAverage,
            Action<clsStudent, float, bool> printInfo, Predicate<float> IsPassed)
        {
            foreach (var student in students)
            {
                float average = calculateAverage(student.Grades);
                bool passed = IsPassed(average);
                printInfo(student, average, passed);
            }
        }
    }
}
