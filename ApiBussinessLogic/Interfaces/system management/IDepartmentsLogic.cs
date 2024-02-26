using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IDepartmentsLogic
    {
        bool Update(departments obj);
        int Insert(departments obj);
        IEnumerable<departments> GetList();
        departments GetById(int id);
        departments GetByIdString(string id);
        bool Delete(departments obj);
    }
}