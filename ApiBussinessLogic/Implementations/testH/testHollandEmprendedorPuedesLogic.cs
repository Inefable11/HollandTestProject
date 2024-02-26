using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandEmprendedorPuedesLogic : ITesthollandemprendedorpuedesLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandEmprendedorPuedesLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandEmprendedorPuedes GetById(int id)
        {
            return _unitOfWork.ITesthollandemprendedorpuedes.GetById(id);
        }

        public testHollandEmprendedorPuedes GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandemprendedorpuedes.GetByIdString(id);
        }

        public IEnumerable<testHollandEmprendedorPuedes> GetList()
        {
            return _unitOfWork.ITesthollandemprendedorpuedes.GetList();
        }

        public int Insert(testHollandEmprendedorPuedes obj)
        {
            return _unitOfWork.ITesthollandemprendedorpuedes.Insert(obj);
        }

        public bool Update(testHollandEmprendedorPuedes obj)
        {
            return _unitOfWork.ITesthollandemprendedorpuedes.Update(obj);
        }

        public bool Delete(testHollandEmprendedorPuedes obj)
        {
            return _unitOfWork.ITesthollandemprendedorpuedes.Delete(obj);
        }
    }
}
