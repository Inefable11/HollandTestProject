using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandConvencionalEresLogic : ITesthollandconvencionaleresLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandConvencionalEresLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandConvencionalEres GetById(int id)
        {
            return _unitOfWork.ITesthollandconvencionaleres.GetById(id);
        }

        public testHollandConvencionalEres GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandconvencionaleres.GetByIdString(id);
        }

        public IEnumerable<testHollandConvencionalEres> GetList()
        {
            return _unitOfWork.ITesthollandconvencionaleres.GetList();
        }

        public int Insert(testHollandConvencionalEres obj)
        {
            return _unitOfWork.ITesthollandconvencionaleres.Insert(obj);
        }

        public bool Update(testHollandConvencionalEres obj)
        {
            return _unitOfWork.ITesthollandconvencionaleres.Update(obj);
        }

        public bool Delete(testHollandConvencionalEres obj)
        {
            return _unitOfWork.ITesthollandconvencionaleres.Delete(obj);
        }
    }
}
