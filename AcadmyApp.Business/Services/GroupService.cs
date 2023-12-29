using AcadmyApp.Business.Interface;
using AcadmyApp.DataContext.Repositories;
using AcadmyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadmyApp.Business.Services
{
    public class GroupService : IGroup
    {
        private readonly GroupRepository groupRepository;
        private readonly StudentRepository StudentRepository;

        private static int Count = 1;
        public GroupService()
        {
            groupRepository = new GroupRepository();
        }

        public List<Group> getAll()
        {
            return groupRepository.GetAll();
        }

        public List<Group> getAll(int size)
        {
            throw new NotImplementedException();
        }

        public Group get(int id)
        {
            throw new NotImplementedException();
        }

        public Group Delete(int id)
        {
            var existedGroup = groupRepository.Get(s => s.Id == id);
            if (existedGroup is null) return null;
            if (groupRepository.Delete(existedGroup))
            {
                var stuList = StudentRepository.GetAll(s => s.Id == id);
                if (stuList.Count > 0)
                {
                    foreach (var stu in stuList)
                    {
                        StudentRepository.Delete(stu);
                    }
                }
            }
            return null;
        }

        public Group get(string name)
        {
            throw new NotImplementedException();
        }

        

        

        List<Group> IGroup.getAll()
        {
            throw new NotImplementedException();
        }

        List<Group> IGroup.getAll(int size)
        {
            throw new NotImplementedException();
        }

        Group IGroup.get(int id)
        {
            throw new NotImplementedException();
        }

        Group IGroup.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Group IGroup.get(string name)
        {
            throw new NotImplementedException();
        }

        public Group Create(Group group)
        {
            var existGroupWithName = groupRepository.Get(g => g.Name.Equals(group.Name, StringComparison.OrdinalIgnoreCase));
            if (existGroupWithName is not null) return null;

            group.Id = Count;
            var result = groupRepository.Create(group);
            if (result)
            {
                Count++;
                return group;
            }
            else
            {
                return null;
            }
        }

        public Group update(int id, Group group)
        {
            var existGroup = groupRepository.Get(g => g.Id == id);
            if (existGroup is null) return null;
            var existGroupWithName = groupRepository.Get(g => g.Name.Equals(group.Name, StringComparison.OrdinalIgnoreCase) && g.Id != existGroup.Id);
            if (existGroupWithName is not null) return null;
            existGroup.Name = group.Name;
            var result = groupRepository.Update(group);
            if (result)
            {
                return existGroup;
            }
            return null;
        }
    }
}
