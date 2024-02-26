using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class studyInstitutionsLogic : IStudyinstitutionsLogic
    {
        private IUnitOfWork _unitOfWork;

        public studyInstitutionsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public studyInstitutions GetById(int id)
        {
            return _unitOfWork.IStudyinstitutions.GetById(id);
        }

        public studyInstitutions GetByIdString(string id)
        {
            return _unitOfWork.IStudyinstitutions.GetByIdString(id);
        }

        public IEnumerable<studyInstitutions> GetList()
        {
            return _unitOfWork.IStudyinstitutions.GetList();
        }

        public int Insert(studyInstitutions obj)
        {
            return _unitOfWork.IStudyinstitutions.Insert(obj);
        }

        public bool Update(studyInstitutions obj)
        {
            return _unitOfWork.IStudyinstitutions.Update(obj);
        }

        public bool Delete(studyInstitutions obj)
        {
            return _unitOfWork.IStudyinstitutions.Delete(obj);
        }
    }
}
