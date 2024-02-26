using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandInvestigadorPuedesLogic : ITesthollandinvestigadorpuedesLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandInvestigadorPuedesLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandInvestigadorPuedes GetById(int id)
        {
            return _unitOfWork.ITesthollandinvestigadorpuedes.GetById(id);
        }

        public testHollandInvestigadorPuedes GetByIdString(string id)
        {
            return _unitOfWork.ITesthollandinvestigadorpuedes.GetByIdString(id);
        }

        public IEnumerable<testHollandInvestigadorPuedes> GetList()
        {
            return _unitOfWork.ITesthollandinvestigadorpuedes.GetList();
        }

        public int Insert(testHollandInvestigadorPuedes obj)
        {
            return _unitOfWork.ITesthollandinvestigadorpuedes.Insert(obj);
        }

        public bool Update(testHollandInvestigadorPuedes obj)
        {
            return _unitOfWork.ITesthollandinvestigadorpuedes.Update(obj);
        }

        public bool Delete(testHollandInvestigadorPuedes obj)
        {
            return _unitOfWork.ITesthollandinvestigadorpuedes.Delete(obj);
        }
    }
}
