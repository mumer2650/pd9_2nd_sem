using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class AbsoluteGradedCourse : Course
    {
        private int marks;
        private string grade;

        public AbsoluteGradedCourse(string name, int marks, string grade) : base(name)
        {
            this.grade = grade;
        }

        public string GetGrade()
        {
            return grade;
        }

        public bool SetGrade(string grade)
        {
            if (grade != "F")
            {
                this.grade = grade;
                return true;
            }
            return false;
        }

        public override bool Passed()
        {
            if (grade == "A+" || grade == "A"  || grade == "B" || grade == "C" || grade == "D")
            {
                return false;
            }
            return true;
        }
    }
}
