using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandInvestigadorTeGustariaLogic : ITesthollandinvestigadortegustariaLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandInvestigadorTeGustariaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandInvestigadorTeGustaria GetById(int id)
        {
            return _unitOfWork.ITesthollandinvestigadortegustaria.GetById(id);
        }

        public testHollandInvestigadorTeGustaria GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandinvestigadortegustaria.GetByIdString(id);
        }

        public IEnumerable<testHollandInvestigadorTeGustaria> GetList()
        {
            return _unitOfWork.ITesthollandinvestigadortegustaria.GetList();
        }

        public int Insert(testHollandInvestigadorTeGustaria obj)
        {
            return _unitOfWork.ITesthollandinvestigadortegustaria.Insert(obj);
        }

        public bool Update(testHollandInvestigadorTeGustaria obj)
        {
            return _unitOfWork.ITesthollandinvestigadortegustaria.Update(obj);
        }

        public bool Delete(testHollandInvestigadorTeGustaria obj)
        {
            return _unitOfWork.ITesthollandinvestigadortegustaria.Delete(obj);
        }

    }
}
