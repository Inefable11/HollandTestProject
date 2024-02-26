using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiModel._RequestDTO;
using ApiModel._ResponseDTO.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.testH
{
    public class testHollandDetailsLogic : ITesthollanddetailsLogic
    {
        private IUnitOfWork _unitOfWork;

        public testHollandDetailsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public testHollandDetails GetById(int id)
        {
            return _unitOfWork.ITesthollanddetails.GetById(id);
        }

        public testHollandDetails GetByIdString(string id)
        {
            return _unitOfWork.ITesthollanddetails.GetByIdString(id);
        }

        public IEnumerable<testHollandDetails> GetList()
        {
            return _unitOfWork.ITesthollanddetails.GetList();
        }

        public int Insert(testHollandDetails obj)
        {
            return _unitOfWork.ITesthollanddetails.Insert(obj);
        }

        public bool Update(testHollandDetails obj)
        {
            return _unitOfWork.ITesthollanddetails.Update(obj);
        }

        public bool Delete(testHollandDetails obj)
        {
            return _unitOfWork.ITesthollanddetails.Delete(obj);
        }

        public IEnumerable<testDetailResponse> GetTestDetail(testDetailRequestDTO obj)
        {
            return _unitOfWork.ITesthollanddetails.GetTestDetail(obj);
        }

        public testHollandDetailsChart GetTestChart(in int id)
        {
            return _unitOfWork.ITesthollanddetails.GetTestChart(id);
        }
    }
}
