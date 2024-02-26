using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandrealistapuedesLogic
    {
        bool Update(testHollandRealistaPuedes obj);
        int Insert(testHollandRealistaPuedes obj);
        IEnumerable<testHollandRealistaPuedes> GetList();
        testHollandRealistaPuedes GetById(int id);
        testHollandRealistaPuedes GetByIdString(string id);
        bool Delete(testHollandRealistaPuedes obj);
    }
}