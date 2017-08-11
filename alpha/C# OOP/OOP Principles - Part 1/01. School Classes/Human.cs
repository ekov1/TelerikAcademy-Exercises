using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_Classes
{
   public abstract class Human
    {
       // Fields
        private string firstName;
        private string secondName;
       
        // Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if(value == null)
                {
                   // throw new ArgumentException
                }
                this.firstName = value;
            }
        }

    }
}
