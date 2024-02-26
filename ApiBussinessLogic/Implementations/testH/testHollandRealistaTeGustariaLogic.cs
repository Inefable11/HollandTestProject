using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandRealistaTeGustariaLogic : ITesthollandrealistategustariaLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandRealistaTeGustariaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandRealistaTeGustaria GetById(int id)
        {
            return _unitOfWork.ITesthollandrealistategustaria.GetById(id);
        }

        public testHollandRealistaTeGustaria GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandrealistategustaria.GetByIdString(id);
        }

        public IEnumerable<testHollandRealistaTeGustaria> GetList()
        {
            return _unitOfWork.ITesthollandrealistategustaria.GetList();
        }

        public int Insert(testHollandRealistaTeGustaria obj)
        {
            return _unitOfWork.ITesthollandrealistategustaria.Insert(obj);
        }

        public bool Update(testHollandRealistaTeGustaria obj)
        {
            return _unitOfWork.ITesthollandrealistategustaria.Update(obj);
        }

        public bool Delete(testHollandRealistaTeGustaria obj)
        {
            return _unitOfWork.ITesthollandrealistategustaria.Delete(obj);
        }
    }
}
