using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class studentDepartamentLogic : IStudentdepartamentLogic
    {
        private IUnitOfWork _unitOfWork;

        public studentDepartamentLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public studentDepartament GetById(int id)
        {
            return _unitOfWork.IStudentdepartament.GetById(id);
        }

        public studentDepartament GetByIdString(string id)
        {
            return _unitOfWork.IStudentdepartament.GetByIdString(id);
        }

        public IEnumerable<studentDepartament> GetList()
        {
            return _unitOfWork.IStudentdepartament.GetList();
        }

        public int Insert(studentDepartament obj)
        {
            return _unitOfWork.IStudentdepartament.Insert(obj);
        }

        public bool Update(studentDepartament obj)
        {
            return _unitOfWork.IStudentdepartament.Update(obj);
        }

        public bool Delete(studentDepartament obj)
        {
            return _unitOfWork.IStudentdepartament.Delete(obj);
        }

    }
}
