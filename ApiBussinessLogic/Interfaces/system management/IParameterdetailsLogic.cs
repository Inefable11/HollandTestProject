using System.Collections.Generic;
using ApiModel.system_management;

namespace ApiBussinessLogic.Interfaces.system_management
{
    public interface IParameterdetailsLogic
    {
        bool Update(parameterDetails obj);
        int Insert(parameterDetails obj);
        IEnumerable<parameterDetails> GetList();
        parameterDetails GetById(int id);
        parameterDetails GetByIdString(string id);
        bool Delete(parameterDetails obj);
    }
}