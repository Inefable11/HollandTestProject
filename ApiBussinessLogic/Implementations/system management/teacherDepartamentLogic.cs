using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class teacherDepartamentLogic : ITeacherdepartamentLogic
    {
        private IUnitOfWork _unitOfWork;

        public teacherDepartamentLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public teacherDepartament GetById(int id)
        {
            return _unitOfWork.ITeacherdepartament.GetById(id);
        }

        public teacherDepartament GetByIdString(string id)
        {
            return _unitOfWork.ITeacherdepartament.GetByIdString(id);
        }

        public IEnumerable<teacherDepartament> GetList()
        {
            return _unitOfWork.ITeacherdepartament.GetList();
        }

        public int Insert(teacherDepartament obj)
        {
            return _unitOfWork.ITeacherdepartament.Insert(obj);
        }

        public bool Update(teacherDepartament obj)
        {
            return _unitOfWork.ITeacherdepartament.Update(obj);
        }

        public bool Delete(teacherDepartament obj)
        {
            return _unitOfWork.ITeacherdepartament.Delete(obj);
        }

    }
}
