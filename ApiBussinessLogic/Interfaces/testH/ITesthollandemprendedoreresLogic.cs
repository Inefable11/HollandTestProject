using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandemprendedoreresLogic
    {
        bool Update(testHollandEmprendedorEres obj);
        int Insert(testHollandEmprendedorEres obj);
        IEnumerable<testHollandEmprendedorEres> GetList();
        testHollandEmprendedorEres GetById(int id);
        testHollandEmprendedorEres GetByIdString(string id);
        bool Delete(testHollandEmprendedorEres obj);
    }
}