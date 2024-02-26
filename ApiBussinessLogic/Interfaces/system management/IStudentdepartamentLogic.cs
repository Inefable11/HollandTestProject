using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IStudentdepartamentLogic
    {
        bool Update(studentDepartament obj);
        int Insert(studentDepartament obj);
        IEnumerable<studentDepartament> GetList();
        studentDepartament GetById(int id);
        studentDepartament GetByIdString(string id);
        bool Delete(studentDepartament obj);
    }
}