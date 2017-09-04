using SoftwareAcademy.Interfaces;
using System;

namespace SoftwareAcademy.Models
{
    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            throw new NotImplementedException();
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            throw new NotImplementedException();
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            throw new NotImplementedException();
        }
    }
}
