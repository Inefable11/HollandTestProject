using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IStaffLogic
    {
        bool Update(staff obj);
        int Insert(staff obj);
        IEnumerable<staff> GetList();
        staff GetById(int id);
        staff GetByIdString(string id);
        bool Delete(staff obj);
    }
}