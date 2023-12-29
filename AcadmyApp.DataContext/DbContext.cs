using AcadmyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadmyApp.DataContext
{
    static class DbContext 
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();

        }
    }
}
