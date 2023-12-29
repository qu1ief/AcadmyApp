using AcadmyApp.Business.Services;
using AcadmyApp.Domain.Models;
using AcadmyApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadmyApp.Controllers
{
    internal class StudentController
    {
        private readonly StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void CreateStudent()
        {
            Helper.changeTextColor(ConsoleColor.Red, "enter student Name");
            string name = Console.ReadLine();
            Helper.changeTextColor(ConsoleColor.Yellow, "enter student SurName");
            string Surname = Console.ReadLine();
            Helper.changeTextColor(ConsoleColor.Green, "enter group ");
            string Groupname = Console.ReadLine();
            Student student = new Student();

            student.Name = name;
            student.SurName = Surname;
            //_studentService.Create(student, Groupname);
            if (_studentService.Create(student, Groupname) is null)
            {
                Helper.changeTextColor(ConsoleColor.Red, "something went wrong");

            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Red, "succesfully created");

            }
        }
        public void getAll()
        {
            Helper.changeTextColor(ConsoleColor.Red, "student list :");
            var studentsGettAll = _studentService.GetAll();
            if (studentsGettAll.Count > 0)
            {
                foreach (var student in studentsGettAll)
                {
                    Helper.changeTextColor(ConsoleColor.Green, $"id:{student.Id} Name:{student.Name} GroupName:{student.group.Name}");

                }
            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Yellow, "empty list");

            }



        }
        public void getAllStudentsWithGroupName()
        {
            Helper.changeTextColor(ConsoleColor.Yellow, "Enter group Name:");
            string GroupName = Console.ReadLine();
            var something = _studentService.getAllStudentsWithGroupName(GroupName);
            foreach (var item in something)
            {
                Console.WriteLine($"id:{item.Id}Name:{item.Name} ");
            }


        }
        public void getAllStudentsWithName()
        {
            Helper.changeTextColor(ConsoleColor.Yellow, "Enter Student Name:");
            string StudentName = Console.ReadLine();
            var something = _studentService.GetAll(StudentName);
            foreach (var item in something)
            {
                Helper.changeTextColor(ConsoleColor.Yellow, $"id:{item.Id}Name:{item.Name} ");
            }

        }
        public void UpdateStudent()
        {
            Helper.changeTextColor(ConsoleColor.Red, "enter Id");
            int id = int.Parse(Console.ReadLine());
            Helper.changeTextColor(ConsoleColor.Red, "enter new student Name");
            string name = Console.ReadLine();
            Helper.changeTextColor(ConsoleColor.Yellow, "enter new student SurName");
            string Surname = Console.ReadLine();
            Helper.changeTextColor(ConsoleColor.Green, "enter groupName ");
            string Groupname = Console.ReadLine();
            Student student = new Student();

            student.Name = name;
            student.SurName = Surname;
            //_studentService.Create(student, Groupname);
            if (_studentService.Uptade(id, student, Groupname) is null)
            {
                Helper.changeTextColor(ConsoleColor.Red, "something went wrong");

            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Green, "succesfully updated");

            }
        }
        public void DeleteStudent()
        {
            Helper.changeTextColor(ConsoleColor.Red, "enter Id");
            int id = int.Parse(Console.ReadLine());
            var result = _studentService.Delete(id);
            if (result == null)
            {
                Helper.changeTextColor(ConsoleColor.Red, "something went wrong");

            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Red, "student deleted");

            }

        }
    }
}
