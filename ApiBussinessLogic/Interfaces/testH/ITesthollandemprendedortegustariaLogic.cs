using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandemprendedortegustariaLogic
    {
        bool Update(testHollandEmprendedorTeGustaria obj);
        int Insert(testHollandEmprendedorTeGustaria obj);
        IEnumerable<testHollandEmprendedorTeGustaria> GetList();
        testHollandEmprendedorTeGustaria GetById(int id);
        testHollandEmprendedorTeGustaria GetByIdString(string id);
        bool Delete(testHollandEmprendedorTeGustaria obj);
    }
}