using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Interfaces
{
    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }
}
