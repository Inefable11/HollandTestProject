using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class accessSystemResponseDTO
    {
        public int id { get; set; }
        public int? idUser { get; set; }
        public int? userType { get; set; }
        public string userName { get; set; }
        public string password { get; set; }


        public accessSystemResponseDTO Mapper(accessSystemResponseDTO dto, accessSystem obj)
        {
            dto.id = obj.id;
            dto.idUser = obj.idUser;
            dto.userType = obj.userType;
            dto.userName = obj.userName;
            dto.password = obj.password;
            return dto;
        }
    }
}
