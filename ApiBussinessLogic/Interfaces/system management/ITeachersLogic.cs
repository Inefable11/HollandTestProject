using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;
using ApiModel._ResponseDTO.testH;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface ITeachersLogic
    {
        bool Update(teachers obj);
        int Insert(teachers obj);
        IEnumerable<teachers> GetList();
        teachers GetById(int id);
        teachers GetByIdString(string id);
        bool Delete(teachers obj);
        IEnumerable<testTeacherGrid> GetTeacherGrid();
        bool validaEmail(string email);
    }
}
