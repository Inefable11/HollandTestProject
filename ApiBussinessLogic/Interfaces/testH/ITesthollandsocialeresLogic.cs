using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandsocialeresLogic
    {
        bool Update(testHollandSocialEres obj);
        int Insert(testHollandSocialEres obj);
        IEnumerable<testHollandSocialEres> GetList();
        testHollandSocialEres GetById(int id);
        testHollandSocialEres GetByIdString(string id);
        bool Delete(testHollandSocialEres obj);
    }
}