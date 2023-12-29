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
    public class GroupController
    {
        private readonly GroupService groupService;

        public GroupController()
        {
            groupService = new GroupService();
        }
        public void CreateGroup()
        {
            Helper.changeTextColor(ConsoleColor.Green, "enter group Name");
            string Groupname = Console.ReadLine();
            Helper.changeTextColor(ConsoleColor.Yellow, "enter student size");
            string size = Console.ReadLine();
            bool result = int.TryParse(size, out int GroupSize);



            //_studentService.Create(student, Groupname);
            if (result)

            {
                Group group = new Group();
                group.Name = Groupname;
                group.MaxSize = GroupSize;
                var createdGroup = groupService.Create(group);
                if (createdGroup is not null)
                {
                    Helper.changeTextColor(ConsoleColor.Yellow, $"{group.Name}it is created succesfully");

                }
                else
                {
                    Helper.changeTextColor(ConsoleColor.Red, "something went wrong");

                }

            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Red, "write size of group properly"); ;

            }
        }
        public void getAllGroup()
        {
            Helper.changeTextColor(ConsoleColor.Red, "egroup list :");
            var groups = groupService.getAll();
            if (groups.Count > 0)
            {
                foreach (var group in groups)
                {
                    Helper.changeTextColor(ConsoleColor.Blue, $"id:{group.Id} name: {group.Name} size :{group.MaxSize}");

                }
            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Red, "empty list");

            }

        }
        public void UpdateGroup()
        {
            Helper.changeTextColor(ConsoleColor.Red, "enter Id");
            int id = int.Parse(Console.ReadLine());
            Helper.changeTextColor(ConsoleColor.Red, "enter size");
            int size = int.Parse(Console.ReadLine());
            Helper.changeTextColor(ConsoleColor.Green, "enter groupName ");
            string Groupname = Console.ReadLine();
            Group group = new();

            group.Name = Groupname;
            group.MaxSize = size;
            var createdGroup = groupService.update(id, group);
            if (createdGroup != null)
            {
                Helper.changeTextColor(ConsoleColor.Green, $"{group.Name} uptaded succesfully ");

            }
            else
            {
                Helper.changeTextColor(ConsoleColor.Red, "something went wrong ");

            }

        }
        public void DeleteGroup()
        {
            Helper.changeTextColor(ConsoleColor.Red, "enter Id");
            int id = int.Parse(Console.ReadLine());
            var result = groupService.Delete(id);
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
