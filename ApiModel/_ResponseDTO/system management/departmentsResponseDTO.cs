using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class departmentsResponseDTO
    {
        public int id { get; set; }
        public string dName { get; set; }
        public string hod { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int sYear { get; set; }
        public int sCapacity { get; set; }


        public departmentsResponseDTO Mapper(departmentsResponseDTO dto, departments obj)
        {
            dto.id = obj.id;
            dto.dName = obj.dName;
            dto.hod = obj.hod;
            dto.phone = obj.phone;
            dto.email = obj.email;
            dto.sYear = obj.sYear;
            dto.sCapacity = obj.sCapacity;
            return dto;
        }
    }
}
