using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddProject();
        }

        public static void AddProject()
        {
            int count = 0;
            Console.Clear();
            Console.WriteLine("**************  ADD Projects   ************");
            Console.WriteLine(" ");
            Console.WriteLine(" How Many Projects you want to Add ?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("**************  ADD Projects   ************");
            Console.WriteLine(" ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Project {i + 1} : ");
                string project_name = Console.ReadLine();
                Project project = new Project(project_name);

                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"   * Course {j + 1}: (Absolute Graded) ");
                    string course_name = Console.ReadLine();
                    Console.Write("         * Marks : ");
                    int marks = Convert.ToInt32(Console.ReadLine());
                    Console.Write("         * Grade : ");
                    string grade = (Console.ReadLine());
                    AbsoluteGradedCourse course = new AbsoluteGradedCourse(course_name, marks, grade);
                    if (course.Passed())
                    {
                        count++;
                    }
                    project.AddCourse(course);
                }

                for (int j = 2; j < 4; j++)
                {
                    Console.Write($"   * Course {j + 1}: (Graded) ");
                    string course_name = Console.ReadLine();
                    Console.Write("         * Grade : ");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    GradedCourse course = new GradedCourse(course_name, grade);
                    if (course.Passed())
                    {
                        count++;
                    }
                    project.AddCourse(course);
                }

                if (count > 1)
                {
                    Console.WriteLine($"Project : {project.GetProject()} is Passed");
                }
                else
                {
                    Console.WriteLine($"Project : {project.GetProject()} is Failed");
                }
            }

        }
    }
}
