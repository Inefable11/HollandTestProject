using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandRealistaEresLogic:ITesthollandrealistaeresLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandRealistaEresLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandRealistaEres GetById(int id)
        {
            return _unitOfWork.ITesthollandrealistaeres.GetById(id);
        }

        public testHollandRealistaEres GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandrealistaeres.GetByIdString(id);
        }

        public IEnumerable<testHollandRealistaEres> GetList()
        {
            return _unitOfWork.ITesthollandrealistaeres.GetList();
        }

        public int Insert(testHollandRealistaEres obj)
        {
            return _unitOfWork.ITesthollandrealistaeres.Insert(obj);
        }

        public bool Update(testHollandRealistaEres obj)
        {
            return _unitOfWork.ITesthollandrealistaeres.Update(obj);
        }

        public bool Delete(testHollandRealistaEres obj)
        {
            return _unitOfWork.ITesthollandrealistaeres.Delete(obj);
        }
    }
}
