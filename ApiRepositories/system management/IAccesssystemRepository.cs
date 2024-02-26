using ApiModel.system_management;

namespace ApiRepositories.system_management
{
    public interface IAccesssystemRepository : IRepository<accessSystem>
    {
        staff LoguearUsuarioStaff(CredencialesUsuaroBE usuario);
        teachers LoguearUsuarioTeacher(CredencialesUsuaroBE usuario);
        students LoguearUsuarioStudent(CredencialesUsuaroBE usuario);
        accessSystem GetByUpdate(in int objId, in int i);
        bool deleteAccesos(string username);
    }
}