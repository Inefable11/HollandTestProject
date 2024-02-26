using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandEmprendedorTeGustariaLogic : ITesthollandemprendedortegustariaLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandEmprendedorTeGustariaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandEmprendedorTeGustaria GetById(int id)
        {
            return _unitOfWork.ITesthollandemprendedortegustaria.GetById(id);
        }

        public testHollandEmprendedorTeGustaria GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandemprendedortegustaria.GetByIdString(id);
        }

        public IEnumerable<testHollandEmprendedorTeGustaria> GetList()
        {
            return _unitOfWork.ITesthollandemprendedortegustaria.GetList();
        }

        public int Insert(testHollandEmprendedorTeGustaria obj)
        {
            return _unitOfWork.ITesthollandemprendedortegustaria.Insert(obj);
        }

        public bool Update(testHollandEmprendedorTeGustaria obj)
        {
            return _unitOfWork.ITesthollandemprendedortegustaria.Update(obj);
        }

        public bool Delete(testHollandEmprendedorTeGustaria obj)
        {
            return _unitOfWork.ITesthollandemprendedortegustaria.Delete(obj);
        }

    }
}
