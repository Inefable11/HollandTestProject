using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandinvestigadoreresLogic
    {
        bool Update(testHollandInvestigadorEres obj);
        int Insert(testHollandInvestigadorEres obj);
        IEnumerable<testHollandInvestigadorEres> GetList();
        testHollandInvestigadorEres GetById(int id);
        testHollandInvestigadorEres GetByIdString(string id);
        bool Delete(testHollandInvestigadorEres obj);
    }
}