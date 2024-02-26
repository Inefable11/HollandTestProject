using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandrealistaeresLogic
    {
        bool Update(testHollandRealistaEres obj);
        int Insert(testHollandRealistaEres obj);
        IEnumerable<testHollandRealistaEres> GetList();
        testHollandRealistaEres GetById(int id);
        testHollandRealistaEres GetByIdString(string id);
        bool Delete(testHollandRealistaEres obj);
    }
}