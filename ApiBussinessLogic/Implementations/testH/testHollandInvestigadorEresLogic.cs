using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandInvestigadorEresLogic : ITesthollandinvestigadoreresLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandInvestigadorEresLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandInvestigadorEres GetById(int id)
        {
            return _unitOfWork.ITesthollandinvestigadoreres.GetById(id);
        }

        public testHollandInvestigadorEres GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandinvestigadoreres.GetByIdString(id);
        }

        public IEnumerable<testHollandInvestigadorEres> GetList()
        {
            return _unitOfWork.ITesthollandinvestigadoreres.GetList();
        }

        public int Insert(testHollandInvestigadorEres obj)
        {
            return _unitOfWork.ITesthollandinvestigadoreres.Insert(obj);
        }

        public bool Update(testHollandInvestigadorEres obj)
        {
            return _unitOfWork.ITesthollandinvestigadoreres.Update(obj);
        }

        public bool Delete(testHollandInvestigadorEres obj)
        {
            return _unitOfWork.ITesthollandinvestigadoreres.Delete(obj);
        }
    }
}
