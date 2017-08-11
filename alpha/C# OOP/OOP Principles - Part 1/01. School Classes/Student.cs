using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_Classes
{
    public class Student : Human
    {
        private int grade;

        // Constructors
        public Student (int grade)
        {
            this.Grade = grade;
        }

        #region Properties
        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new Exception("student grade must be between 2 and 6");
                }
                this.grade = value;
            }
        }
        #endregion
    }
}
