using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandsocialpuedesLogic
    {
        bool Update(testHollandSocialPuedes obj);
        int Insert(testHollandSocialPuedes obj);
        IEnumerable<testHollandSocialPuedes> GetList();
        testHollandSocialPuedes GetById(int id);
        testHollandSocialPuedes GetByIdString(string id);
        bool Delete(testHollandSocialPuedes obj);
    }
}