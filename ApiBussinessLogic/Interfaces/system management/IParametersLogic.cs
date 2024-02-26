using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IParametersLogic
    {
        bool Update(parameters obj);
        int Insert(parameters obj);
        IEnumerable<parameters> GetList();
        parameters GetById(int id);
        parameters GetByIdString(string id);
        bool Delete(parameters obj);
    }
}