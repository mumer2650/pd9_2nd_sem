using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Project
    {
        private string project_name;    
        public List<Course> courses = new List<Course> ();

        public Project(string project_name)
        {
            this.project_name = project_name;
        }

        public string GetProject()
        {
            return project_name;
        }
            
        public void SetProject(string project_name)
        {
            this.project_name = project_name;
        }

        public void AddCourse(GradedCourse c)
        {
            courses.Add(c);
        }

        public void AddCourse(AbsoluteGradedCourse c)
        {
            courses.Add(c);
        }
    }
}
