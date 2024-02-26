using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandconvencionaltegustariaLogic
    {
        bool Update(testHollandConvencionalTeGustaria obj);
        int Insert(testHollandConvencionalTeGustaria obj);
        IEnumerable<testHollandConvencionalTeGustaria> GetList();
        testHollandConvencionalTeGustaria GetById(int id);
        testHollandConvencionalTeGustaria GetByIdString(string id);
        bool Delete(testHollandConvencionalTeGustaria obj);
    }
}