using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandemprendedorpuedesLogic
    {
        bool Update(testHollandEmprendedorPuedes obj);
        int Insert(testHollandEmprendedorPuedes obj);
        IEnumerable<testHollandEmprendedorPuedes> GetList();
        testHollandEmprendedorPuedes GetById(int id);
        testHollandEmprendedorPuedes GetByIdString(string id);
        bool Delete(testHollandEmprendedorPuedes obj);
    }
}