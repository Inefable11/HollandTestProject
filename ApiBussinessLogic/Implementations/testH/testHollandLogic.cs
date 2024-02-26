using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandLogic:ITesthollandLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHolland GetById(int id)
        {
            return _unitOfWork.ITestholland.GetById(id);
        }

        public testHolland GetByIdString(string id)
        {
            return _unitOfWork.ITestholland.GetByIdString(id);
        }

        public IEnumerable<testHolland> GetList()
        {
            return _unitOfWork.ITestholland.GetList();
        }

        public int Insert(testHolland obj)
        {
            return _unitOfWork.ITestholland.Insert(obj);
        }

        public bool Update(testHolland obj)
        {
            return _unitOfWork.ITestholland.Update(obj);
        }

        public bool Delete(testHolland obj)
        {
            return _unitOfWork.ITestholland.Delete(obj);
        }
    }
}
