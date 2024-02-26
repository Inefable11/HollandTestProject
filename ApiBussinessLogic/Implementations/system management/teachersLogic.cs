using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiModel._ResponseDTO.testH;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class teachersLogic : ITeachersLogic
    {
        private IUnitOfWork _unitOfWork;

        public teachersLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public teachers GetById(int id)
        {
            return _unitOfWork.ITeachers.GetById(id);
        }

        public teachers GetByIdString(string id)
        {
            return _unitOfWork.ITeachers.GetByIdString(id);
        }

        public IEnumerable<teachers> GetList()
        {
            return _unitOfWork.ITeachers.GetList();
        }

        public int Insert(teachers obj)
        {
            return _unitOfWork.ITeachers.Insert(obj);
        }

        public bool Update(teachers obj)
        {
            return _unitOfWork.ITeachers.Update(obj);
        }

        public bool Delete(teachers obj)
        {
            return _unitOfWork.ITeachers.Delete(obj);
        }

        public IEnumerable<testTeacherGrid> GetTeacherGrid()
        {
            return _unitOfWork.ITeachers.GetTeacherGrid();
        }

        public bool validaEmail(string email)
        {
            return _unitOfWork.ITeachers.validaEmail(email);
        }
    }
    
}
