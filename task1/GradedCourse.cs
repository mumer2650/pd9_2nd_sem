using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class GradedCourse : Course
    {
        private int grade;

        public GradedCourse(string name,int grade) : base(name)
        {
            this.grade = grade;
        }

        public int getGrade()
        {
            return grade;
        }
        public bool setGrade(int grade)
        {
            if (grade == 12 || grade == 10 || grade == 7 || grade == 4 || grade == 2 || grade == 0 || grade == -3)
            {
                this.grade = grade;
                return true;
            }
            return false;
        }

        public override bool Passed()
        {
            if (this.grade == -3)
            {
                return false;
            }
            return true;
        }

    }
}
