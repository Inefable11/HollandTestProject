using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface ITesthollandartisticoeresLogic
    {
        bool Update(testHollandArtisticoEres obj);
        int Insert(testHollandArtisticoEres obj);
        IEnumerable<testHollandArtisticoEres> GetList();
        testHollandArtisticoEres GetById(int id);
        testHollandArtisticoEres GetByIdString(string id);
        bool Delete(testHollandArtisticoEres obj);
    }
}