using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class accessSystemLogic : IAccesssystemLogic
    {
        private IUnitOfWork _unitOfWork;

        public accessSystemLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public accessSystem GetById(int id)
        {
            return _unitOfWork.IAccesssystem.GetById(id);
        }

        public accessSystem GetByIdString(string id)
        {
            return _unitOfWork.IAccesssystem.GetByIdString(id);
        }

        public IEnumerable<accessSystem> GetList()
        {
            return _unitOfWork.IAccesssystem.GetList();
        }

        public int Insert(accessSystem obj)
        {
            return _unitOfWork.IAccesssystem.Insert(obj);
        }

        public bool Update(accessSystem obj)
        {
            return _unitOfWork.IAccesssystem.Update(obj);
        }

        public bool Delete(accessSystem obj)
        {
            return _unitOfWork.IAccesssystem.Delete(obj);
        }

        public staff LoguearUsuarioStaff(CredencialesUsuaroBE usuario)
        {
            return _unitOfWork.IAccesssystem.LoguearUsuarioStaff(usuario);
        }

        public teachers LoguearUsuarioTeacher(CredencialesUsuaroBE usuario)
        {
            return _unitOfWork.IAccesssystem.LoguearUsuarioTeacher(usuario);
        }

        public students LoguearUsuarioStudent(CredencialesUsuaroBE usuario)
        {
            return _unitOfWork.IAccesssystem.LoguearUsuarioStudent(usuario);
        }

        public accessSystem GetByUpdate(in int objId, int i)
        {
            return _unitOfWork.IAccesssystem.GetByUpdate(objId, i);
        }

        public bool deleteAccesos(string username)
        {
            return _unitOfWork.IAccesssystem.deleteAccesos(username);
        }
    }
}
