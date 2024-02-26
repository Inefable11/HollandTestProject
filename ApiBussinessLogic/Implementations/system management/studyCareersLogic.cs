using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class studyCareersLogic : IStudycareersLogic
    {
        private IUnitOfWork _unitOfWork;

        public studyCareersLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public studyCareers GetById(int id)
        {
            return _unitOfWork.IStudycareers.GetById(id);
        }

        public studyCareers GetByIdString(string id)
        {
            return _unitOfWork.IStudycareers.GetByIdString(id);
        }

        public IEnumerable<studyCareers> GetList()
        {
            return _unitOfWork.IStudycareers.GetList();
        }

        public int Insert(studyCareers obj)
        {
            return _unitOfWork.IStudycareers.Insert(obj);
        }

        public bool Update(studyCareers obj)
        {
            return _unitOfWork.IStudycareers.Update(obj);
        }

        public bool Delete(studyCareers obj)
        {
            return _unitOfWork.IStudycareers.Delete(obj);
        }
    }
}
