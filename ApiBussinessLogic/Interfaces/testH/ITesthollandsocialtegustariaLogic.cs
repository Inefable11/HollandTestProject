using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandsocialtegustariaLogic
    {
        bool Update(testHollandSocialTeGustaria obj);
        int Insert(testHollandSocialTeGustaria obj);
        IEnumerable<testHollandSocialTeGustaria> GetList();
        testHollandSocialTeGustaria GetById(int id);
        testHollandSocialTeGustaria GetByIdString(string id);
        bool Delete(testHollandSocialTeGustaria obj);
    }
}