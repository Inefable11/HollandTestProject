using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandRealistaPuedesLogic : ITesthollandrealistapuedesLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandRealistaPuedesLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandRealistaPuedes GetById(int id)
        {
            return _unitOfWork.ITesthollandrealistapuedes.GetById(id);
        }

        public testHollandRealistaPuedes GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandrealistapuedes.GetByIdString(id);
        }

        public IEnumerable<testHollandRealistaPuedes> GetList()
        {
            return _unitOfWork.ITesthollandrealistapuedes.GetList();
        }

        public int Insert(testHollandRealistaPuedes obj)
        {
            return _unitOfWork.ITesthollandrealistapuedes.Insert(obj);
        }

        public bool Update(testHollandRealistaPuedes obj)
        {
            return _unitOfWork.ITesthollandrealistapuedes.Update(obj);
        }

        public bool Delete(testHollandRealistaPuedes obj)
        {
            return _unitOfWork.ITesthollandrealistapuedes.Delete(obj);
        }
    }
}
