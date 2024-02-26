using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandArtisticoEresLogic : ITesthollandartisticoeresLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandArtisticoEresLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandArtisticoEres GetById(int id)
        {
            return _unitOfWork.ITesthollandartisticoeres.GetById(id);
        }

        public testHollandArtisticoEres GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandartisticoeres.GetByIdString(id);
        }

        public IEnumerable<testHollandArtisticoEres> GetList()
        {
            return _unitOfWork.ITesthollandartisticoeres.GetList();
        }

        public int Insert(testHollandArtisticoEres obj)
        {
            return _unitOfWork.ITesthollandartisticoeres.Insert(obj);
        }

        public bool Update(testHollandArtisticoEres obj)
        {
            return _unitOfWork.ITesthollandartisticoeres.Update(obj);
        }

        public bool Delete(testHollandArtisticoEres obj)
        {
            return _unitOfWork.ITesthollandartisticoeres.Delete(obj);
        }
    }
}
