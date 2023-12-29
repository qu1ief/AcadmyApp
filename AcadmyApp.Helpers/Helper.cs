using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadmyApp.Helpers
{
    public class Helper
    {
        public static void changeTextColor(ConsoleColor consoleColor, string word)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(word);
            Console.ResetColor();
        }
        public enum Menus
        {
            createStudent = 1,
            getAllStudents,
            getAllStudentsWithName,
            getStudentById,
            DeleteStudent,
            UpdateStudent,
            CreateGroup,
            getAllGroups,
            getAllStudentsWithGroupName,
            UpdateGroup,
            deleteGroup




        }
    }
}
