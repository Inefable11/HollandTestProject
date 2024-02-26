using System.Collections.Generic;
using ApiModel.system_management;
using ApiModel._ResponseDTO.testH;

namespace ApiRepositories.system_management
{
    public interface ITeachersRepository : IRepository<teachers>
    {
        IEnumerable<testTeacherGrid> GetTeacherGrid();
        bool validaEmail(string email);
    }
}