using AcadmyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadmyApp.Business.Interface
{
    public interface IGroup
    {
        List<Group> getAll();
        List<Group> getAll(int size);
        Group get(int id);
        Group Delete(int id);
        Group get(string name);
        Group Create(Group group);
        Group update(int id, Group group);
    }
}
