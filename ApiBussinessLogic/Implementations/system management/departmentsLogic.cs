using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class departmentsLogic : IDepartmentsLogic
    {
        private IUnitOfWork _unitOfWork;

        public departmentsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public departments GetById(int id)
        {
            return _unitOfWork.IDepartments.GetById(id);
        }

        public departments GetByIdString(string id)
        {
            return _unitOfWork.IDepartments.GetByIdString(id);
        }

        public IEnumerable<departments> GetList()
        {
            return _unitOfWork.IDepartments.GetList();
        }

        public int Insert(departments obj)
        {
            return _unitOfWork.IDepartments.Insert(obj);
        }

        public bool Update(departments obj)
        {
            return _unitOfWork.IDepartments.Update(obj);
        }

        public bool Delete(departments obj)
        {
            return _unitOfWork.IDepartments.Delete(obj);
        }
    }
}
