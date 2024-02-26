using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IStudyinstitutionsLogic
    {
        bool Update(studyInstitutions obj);
        int Insert(studyInstitutions obj);
        IEnumerable<studyInstitutions> GetList();
        studyInstitutions GetById(int id);
        studyInstitutions GetByIdString(string id);
        bool Delete(studyInstitutions obj);
    }
}