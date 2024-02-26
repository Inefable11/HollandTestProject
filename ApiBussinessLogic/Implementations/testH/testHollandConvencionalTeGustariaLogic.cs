using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandConvencionalTeGustariaLogic : ITesthollandconvencionaltegustariaLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandConvencionalTeGustariaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandConvencionalTeGustaria GetById(int id)
        {
            return _unitOfWork.ITesthollandconvencionaltegustaria.GetById(id);
        }

        public testHollandConvencionalTeGustaria GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandconvencionaltegustaria.GetByIdString(id);
        }

        public IEnumerable<testHollandConvencionalTeGustaria> GetList()
        {
            return _unitOfWork.ITesthollandconvencionaltegustaria.GetList();
        }

        public int Insert(testHollandConvencionalTeGustaria obj)
        {
            return _unitOfWork.ITesthollandconvencionaltegustaria.Insert(obj);
        }

        public bool Update(testHollandConvencionalTeGustaria obj)
        {
            return _unitOfWork.ITesthollandconvencionaltegustaria.Update(obj);
        }

        public bool Delete(testHollandConvencionalTeGustaria obj)
        {
            return _unitOfWork.ITesthollandconvencionaltegustaria.Delete(obj);
        }
    }
}
