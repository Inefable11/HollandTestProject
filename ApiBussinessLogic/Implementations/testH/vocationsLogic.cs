using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class vocationsLogic : IVocationsLogic
    {
        private IUnitOfWork _unitOfWork;

        public vocationsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public vocations GetById(int id)
        {
            return _unitOfWork.IVocations.GetById(id);
        }

        public IEnumerable<vocations> GetList()
        {
            return _unitOfWork.IVocations.GetList();
        }

        public int Insert(vocations obj)
        {
            return _unitOfWork.IVocations.Insert(obj);
        }

        public bool Update(vocations obj)
        {
            return _unitOfWork.IVocations.Update(obj);
        }

        public bool Delete(vocations obj)
        {
            return _unitOfWork.IVocations.Delete(obj);
        }
    }
}
