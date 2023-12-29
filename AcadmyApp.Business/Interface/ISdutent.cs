using AcadmyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadmyApp.Business.Interface
{
    public interface IStudent
    {
        List<Student> GetAll();
        List<Student> getAllStudentsWithGroupName(string groupName);
        List<Student> GetAll(string name);
        List<Student> GetAll(int age);

        Student Get(int id);
        Student Delete(int id);
        Student Uptade(int id, Student student, string groupName);
        Student Create(Student student, string groupName);
    }
}
