using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandLogic
    {
        bool Update(testHolland obj);
        int Insert(testHolland obj);
        IEnumerable<testHolland> GetList();
        testHolland GetById(int id);
        testHolland GetByIdString(string id);
        bool Delete(testHolland obj);
    }
}
