using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandEmprendedorEresLogic : ITesthollandemprendedoreresLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandEmprendedorEresLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandEmprendedorEres GetById(int id)
        {
            return _unitOfWork.ITesthollandemprendedoreres.GetById(id);
        }

        public testHollandEmprendedorEres GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandemprendedoreres.GetByIdString(id);
        }

        public IEnumerable<testHollandEmprendedorEres> GetList()
        {
            return _unitOfWork.ITesthollandemprendedoreres.GetList();
        }

        public int Insert(testHollandEmprendedorEres obj)
        {
            return _unitOfWork.ITesthollandemprendedoreres.Insert(obj);
        }

        public bool Update(testHollandEmprendedorEres obj)
        {
            return _unitOfWork.ITesthollandemprendedoreres.Update(obj);
        }

        public bool Delete(testHollandEmprendedorEres obj)
        {
            return _unitOfWork.ITesthollandemprendedoreres.Delete(obj);
        }

    }
}
