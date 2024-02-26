using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandinvestigadortegustariaLogic
    {
        bool Update(testHollandInvestigadorTeGustaria obj);
        int Insert(testHollandInvestigadorTeGustaria obj);
        IEnumerable<testHollandInvestigadorTeGustaria> GetList();
        testHollandInvestigadorTeGustaria GetById(int id);
        testHollandInvestigadorTeGustaria GetByIdString(string id);
        bool Delete(testHollandInvestigadorTeGustaria obj);
    }
}