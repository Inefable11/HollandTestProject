using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandartisticotegustariaLogic
    {
        bool Update(testHollandArtisticoTeGustaria obj);
        int Insert(testHollandArtisticoTeGustaria obj);
        IEnumerable<testHollandArtisticoTeGustaria> GetList();
        testHollandArtisticoTeGustaria GetById(int id);
        testHollandArtisticoTeGustaria GetByIdString(string id);
        bool Delete(testHollandArtisticoTeGustaria obj);
    }
}