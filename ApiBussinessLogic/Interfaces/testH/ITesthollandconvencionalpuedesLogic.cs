using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandconvencionalpuedesLogic
    {
        bool Update(testHollandConvencionalPuedes obj);
        int Insert(testHollandConvencionalPuedes obj);
        IEnumerable<testHollandConvencionalPuedes> GetList();
        testHollandConvencionalPuedes GetById(int id);
        testHollandConvencionalPuedes GetByIdString(string id);
        bool Delete(testHollandConvencionalPuedes obj);
    }
}