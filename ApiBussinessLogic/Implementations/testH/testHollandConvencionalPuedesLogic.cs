using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandConvencionalPuedesLogic : ITesthollandconvencionalpuedesLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandConvencionalPuedesLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandConvencionalPuedes GetById(int id)
        {
            return _unitOfWork.ITesthollandconvencionalpuedes.GetById(id);
        }

        public testHollandConvencionalPuedes GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandconvencionalpuedes.GetByIdString(id);
        }

        public IEnumerable<testHollandConvencionalPuedes> GetList()
        {
            return _unitOfWork.ITesthollandconvencionalpuedes.GetList();
        }

        public int Insert(testHollandConvencionalPuedes obj)
        {
            return _unitOfWork.ITesthollandconvencionalpuedes.Insert(obj);
        }

        public bool Update(testHollandConvencionalPuedes obj)
        {
            return _unitOfWork.ITesthollandconvencionalpuedes.Update(obj);
        }

        public bool Delete(testHollandConvencionalPuedes obj)
        {
            return _unitOfWork.ITesthollandconvencionalpuedes.Delete(obj);
        }
    }
}
