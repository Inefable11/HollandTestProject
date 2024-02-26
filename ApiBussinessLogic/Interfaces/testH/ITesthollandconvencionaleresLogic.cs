using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandconvencionaleresLogic
    {
        bool Update(testHollandConvencionalEres obj);
        int Insert(testHollandConvencionalEres obj);
        IEnumerable<testHollandConvencionalEres> GetList();
        testHollandConvencionalEres GetById(int id);
        testHollandConvencionalEres GetByIdString(string id);
        bool Delete(testHollandConvencionalEres obj);
    }
}