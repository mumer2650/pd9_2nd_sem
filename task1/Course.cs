using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal abstract class Course
    {
        protected string course_name;

        public Course(string name)
        {
            this.course_name = name;
        }
        public string getName()
        {
            return course_name;
        }
        public void setName(string name)
        {
            course_name = name;
        }


        public abstract bool Passed();

    }
}
