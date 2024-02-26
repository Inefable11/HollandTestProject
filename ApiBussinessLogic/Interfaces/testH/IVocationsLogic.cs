using System.Collections.Generic;
using ApiModel.testH;

namespace ApiBussinessLogic.Interfaces.testH
{
    public interface IVocationsLogic
    {
        bool Update(vocations obj);
        int Insert(vocations obj);
        IEnumerable<vocations> GetList();
        vocations GetById(int id);
        bool Delete(vocations obj);
    }
}