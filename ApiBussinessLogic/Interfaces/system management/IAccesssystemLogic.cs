using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IAccesssystemLogic
    {
        bool Update(accessSystem obj);
        int Insert(accessSystem obj);
        IEnumerable<accessSystem> GetList();
        accessSystem GetById(int id);
        accessSystem GetByIdString(string id);
        bool Delete(accessSystem obj);
        staff LoguearUsuarioStaff(CredencialesUsuaroBE usuario);
        teachers LoguearUsuarioTeacher(CredencialesUsuaroBE usuario);
        students LoguearUsuarioStudent(CredencialesUsuaroBE usuario);
        accessSystem GetByUpdate(in int objId, int i);
        bool deleteAccesos(string username);
    }
}