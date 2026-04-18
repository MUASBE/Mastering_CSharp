using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class clsStudent
    {
        public string Name { get; set; }

        public List<float> Grades { get; set; } = new List<float>();
        public clsStudent(string name)
        {
            Name = name;
        }
        
    }
}
