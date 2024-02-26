using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class parameterDetailsLogic : IParameterdetailsLogic
    {
        private IUnitOfWork _unitOfWork;

        public parameterDetailsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public parameterDetails GetById(int id)
        {
            return _unitOfWork.IParameterdetails.GetById(id);
        }

        public parameterDetails GetByIdString(string id)
        {
            return _unitOfWork.IParameterdetails.GetByIdString(id);
        }

        public IEnumerable<parameterDetails> GetList()
        {
            return _unitOfWork.IParameterdetails.GetList();
        }

        public int Insert(parameterDetails obj)
        {
            return _unitOfWork.IParameterdetails.Insert(obj);
        }

        public bool Update(parameterDetails obj)
        {
            return _unitOfWork.IParameterdetails.Update(obj);
        }

        public bool Delete(parameterDetails obj)
        {
            return _unitOfWork.IParameterdetails.Delete(obj);
        }
    }
}
