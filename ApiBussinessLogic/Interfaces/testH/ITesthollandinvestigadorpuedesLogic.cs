using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandinvestigadorpuedesLogic
    {
        bool Update(testHollandInvestigadorPuedes obj);
        int Insert(testHollandInvestigadorPuedes obj);
        IEnumerable<testHollandInvestigadorPuedes> GetList();
        testHollandInvestigadorPuedes GetById(int id);
        testHollandInvestigadorPuedes GetByIdString(string id);
        bool Delete(testHollandInvestigadorPuedes obj);
    }
}