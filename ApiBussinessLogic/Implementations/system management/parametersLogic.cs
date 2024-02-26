using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class parametersLogic : IParametersLogic
    {
        private IUnitOfWork _unitOfWork;

        public parametersLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public parameters GetById(int id)
        {
            return _unitOfWork.IParameters.GetById(id);
        }

        public parameters GetByIdString(string id)
        {
            return _unitOfWork.IParameters.GetByIdString(id);
        }

        public IEnumerable<parameters> GetList()
        {
            return _unitOfWork.IParameters.GetList();
        }

        public int Insert(parameters obj)
        {
            return _unitOfWork.IParameters.Insert(obj);
        }

        public bool Update(parameters obj)
        {
            return _unitOfWork.IParameters.Update(obj);
        }

        public bool Delete(parameters obj)
        {
            return _unitOfWork.IParameters.Delete(obj);
        }
    }
}
