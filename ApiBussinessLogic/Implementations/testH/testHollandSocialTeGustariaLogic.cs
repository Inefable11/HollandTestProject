using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandSocialTeGustariaLogic : ITesthollandsocialtegustariaLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandSocialTeGustariaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandSocialTeGustaria GetById(int id)
        {
            return _unitOfWork.ITesthollandsocialtegustaria.GetById(id);
        }

        public testHollandSocialTeGustaria GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandsocialtegustaria.GetByIdString(id);
        }

        public IEnumerable<testHollandSocialTeGustaria> GetList()
        {
            return _unitOfWork.ITesthollandsocialtegustaria.GetList();
        }

        public int Insert(testHollandSocialTeGustaria obj)
        {
            return _unitOfWork.ITesthollandsocialtegustaria.Insert(obj);
        }

        public bool Update(testHollandSocialTeGustaria obj)
        {
            return _unitOfWork.ITesthollandsocialtegustaria.Update(obj);
        }

        public bool Delete(testHollandSocialTeGustaria obj)
        {
            return _unitOfWork.ITesthollandsocialtegustaria.Delete(obj);
        }
    }
}
