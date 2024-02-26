using System;
using System.Collections.Generic;
using System.Text;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiUnitWork;

namespace ApiBussinessLogic.Implementations.system_management
{
    public class staffLogic : IStaffLogic
    {
        private IUnitOfWork _unitOfWork;

        public staffLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public staff GetById(int id)
        {
            return _unitOfWork.IStaff.GetById(id);
        }

        public staff GetByIdString(string id)
        {
            return _unitOfWork.IStaff.GetByIdString(id);
        }

        public IEnumerable<staff> GetList()
        {
            return _unitOfWork.IStaff.GetList();
        }

        public int Insert(staff obj)
        {
            return _unitOfWork.IStaff.Insert(obj);
        }

        public bool Update(staff obj)
        {
            return _unitOfWork.IStaff.Update(obj);
        }

        public bool Delete(staff obj)
        {
            return _unitOfWork.IStaff.Delete(obj);
        }
    }
}
