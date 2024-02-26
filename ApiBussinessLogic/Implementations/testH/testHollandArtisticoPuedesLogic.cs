using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandArtisticoPuedesLogic : ITesthollandartisticopuedesLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandArtisticoPuedesLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandArtisticoPuedes GetById(int id)
        {
            return _unitOfWork.ITesthollandartisticopuedes.GetById(id);
        }

        public testHollandArtisticoPuedes GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandartisticopuedes.GetByIdString(id);
        }

        public IEnumerable<testHollandArtisticoPuedes> GetList()
        {
            return _unitOfWork.ITesthollandartisticopuedes.GetList();
        }

        public int Insert(testHollandArtisticoPuedes obj)
        {
            return _unitOfWork.ITesthollandartisticopuedes.Insert(obj);
        }

        public bool Update(testHollandArtisticoPuedes obj)
        {
            return _unitOfWork.ITesthollandartisticopuedes.Update(obj);
        }

        public bool Delete(testHollandArtisticoPuedes obj)
        {
            return _unitOfWork.ITesthollandartisticopuedes.Delete(obj);
        }
    }
}
