using System.Collections.Generic;
using ApiModel.testH;
using ApiModel._RequestDTO;
using ApiModel._ResponseDTO.testH;

namespace ApiRepositories.testH
{
    public interface ITesthollanddetailsRepository : IRepository<testHollandDetails>
    {
        IEnumerable<testDetailResponse> GetTestDetail(testDetailRequestDTO testDetailRequestDto);
        testHollandDetailsChart GetTestChart(in int id);
    }
}