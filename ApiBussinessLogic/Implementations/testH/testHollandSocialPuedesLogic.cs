using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandSocialPuedesLogic : ITesthollandsocialpuedesLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandSocialPuedesLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandSocialPuedes GetById(int id)
        {
            return _unitOfWork.ITesthollandsocialpuedes.GetById(id);
        }

        public testHollandSocialPuedes GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandsocialpuedes.GetByIdString(id);
        }

        public IEnumerable<testHollandSocialPuedes> GetList()
        {
            return _unitOfWork.ITesthollandsocialpuedes.GetList();
        }

        public int Insert(testHollandSocialPuedes obj)
        {
            return _unitOfWork.ITesthollandsocialpuedes.Insert(obj);
        }

        public bool Update(testHollandSocialPuedes obj)
        {
            return _unitOfWork.ITesthollandsocialpuedes.Update(obj);
        }

        public bool Delete(testHollandSocialPuedes obj)
        {
            return _unitOfWork.ITesthollandsocialpuedes.Delete(obj);
        }
    }
}
