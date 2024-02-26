using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandSocialEresLogic : ITesthollandsocialeresLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandSocialEresLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandSocialEres GetById(int id)
        {
            return _unitOfWork.ITesthollandsocialeres.GetById(id);
        }

        public testHollandSocialEres GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandsocialeres.GetByIdString(id);
        }

        public IEnumerable<testHollandSocialEres> GetList()
        {
            return _unitOfWork.ITesthollandsocialeres.GetList();
        }

        public int Insert(testHollandSocialEres obj)
        {
            return _unitOfWork.ITesthollandsocialeres.Insert(obj);
        }

        public bool Update(testHollandSocialEres obj)
        {
            return _unitOfWork.ITesthollandsocialeres.Update(obj);
        }

        public bool Delete(testHollandSocialEres obj)
        {
            return _unitOfWork.ITesthollandsocialeres.Delete(obj);
        }
    }
}
