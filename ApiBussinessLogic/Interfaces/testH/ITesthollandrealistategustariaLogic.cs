using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandrealistategustariaLogic
    {
        bool Update(testHollandRealistaTeGustaria obj);
        int Insert(testHollandRealistaTeGustaria obj);
        IEnumerable<testHollandRealistaTeGustaria> GetList();
        testHollandRealistaTeGustaria GetById(int id);
        testHollandRealistaTeGustaria GetByIdString(string id);
        bool Delete(testHollandRealistaTeGustaria obj);
    }
}