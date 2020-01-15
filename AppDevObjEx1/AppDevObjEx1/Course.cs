using System;
using System.Collections.Generic;
using System.Text;

namespace AppDevObjEx1
{
    class Course
    {
        int courseNumber;
        string courseName;

        public Course()
        {
            courseNumber = 1501;
            courseName = "Introduction to App Dev";
        }
        public Course (int _courseNumber)
        {
            courseNumber = _courseNumber;
            courseName = "Introduction to Objects";
        }

        public void Writer()
        {
            Console.WriteLine($"The course number is \"{courseNumber}\"");
            Console.WriteLine($"The course name is \"{courseName}\"");

        }

    }
}
