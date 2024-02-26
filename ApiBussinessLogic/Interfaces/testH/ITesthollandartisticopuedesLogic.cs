using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandartisticopuedesLogic
    {
        bool Update(testHollandArtisticoPuedes obj);
        int Insert(testHollandArtisticoPuedes obj);
        IEnumerable<testHollandArtisticoPuedes> GetList();
        testHollandArtisticoPuedes GetById(int id);
        testHollandArtisticoPuedes GetByIdString(string id);
        bool Delete(testHollandArtisticoPuedes obj);
    }
}