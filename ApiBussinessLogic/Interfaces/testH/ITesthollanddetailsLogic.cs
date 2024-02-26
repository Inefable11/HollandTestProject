using System.Collections.Generic;
using ApiModel.testH;
using ApiModel._RequestDTO;
using ApiModel._ResponseDTO.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollanddetailsLogic
    {
        bool Update(testHollandDetails obj);
        int Insert(testHollandDetails obj);
        IEnumerable<testHollandDetails> GetList();
        testHollandDetails GetById(int id);
        testHollandDetails GetByIdString(string id);
        bool Delete(testHollandDetails obj);
        IEnumerable<testDetailResponse> GetTestDetail(testDetailRequestDTO testDetailRequestDto);
        testHollandDetailsChart GetTestChart(in int id);
    }
}