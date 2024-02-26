using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandArtisticoTeGustariaLogic : ITesthollandartisticotegustariaLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandArtisticoTeGustariaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandArtisticoTeGustaria GetById(int id)
        {
            return _unitOfWork.ITesthollandartisticotegustaria.GetById(id);
        }

        public testHollandArtisticoTeGustaria GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandartisticotegustaria.GetByIdString(id);
        }

        public IEnumerable<testHollandArtisticoTeGustaria> GetList()
        {
            return _unitOfWork.ITesthollandartisticotegustaria.GetList();
        }

        public int Insert(testHollandArtisticoTeGustaria obj)
        {
            return _unitOfWork.ITesthollandartisticotegustaria.Insert(obj);
        }

        public bool Update(testHollandArtisticoTeGustaria obj)
        {
            return _unitOfWork.ITesthollandartisticotegustaria.Update(obj);
        }

        public bool Delete(testHollandArtisticoTeGustaria obj)
        {
            return _unitOfWork.ITesthollandartisticotegustaria.Delete(obj);
        }
    }
}
