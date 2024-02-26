using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface ITeacherdepartamentLogic
    {
        bool Update(teacherDepartament obj);
        int Insert(teacherDepartament obj);
        IEnumerable<teacherDepartament> GetList();
        teacherDepartament GetById(int id);
        teacherDepartament GetByIdString(string id);
        bool Delete(teacherDepartament obj);
    }
}