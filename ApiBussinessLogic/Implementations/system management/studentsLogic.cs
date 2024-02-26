using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class studentsLogic : IStudentsLogic
    {
        private IUnitOfWork _unitOfWork;

        public studentsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public students GetById(int id)
        {
            return _unitOfWork.IStudents.GetById(id);
        }

        public students GetByIdString(string id)
        {
            return _unitOfWork.IStudents.GetByIdString(id);
        }

        public IEnumerable<students> GetList()
        {
            return _unitOfWork.IStudents.GetList();
        }

        public int Insert(students obj)
        {
            return _unitOfWork.IStudents.Insert(obj);
        }

        public bool Update(students obj)
        {
            return _unitOfWork.IStudents.Update(obj);
        }

        public bool Delete(students obj)
        {
            return _unitOfWork.IStudents.Delete(obj);
        }
    }
}
