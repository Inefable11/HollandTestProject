using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IStudentsLogic
    {
        bool Update(students obj);
        int Insert(students obj);
        IEnumerable<students> GetList();
        students GetById(int id);
        students GetByIdString(string id);
        bool Delete(students obj);
    }
}