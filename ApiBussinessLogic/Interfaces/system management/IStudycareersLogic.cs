using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IStudycareersLogic
    {
        bool Update(studyCareers obj);
        int Insert(studyCareers obj);
        IEnumerable<studyCareers> GetList();
        studyCareers GetById(int id);
        studyCareers GetByIdString(string id);
        bool Delete(studyCareers obj);
    }
}