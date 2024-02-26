using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class studentDepartamentResponseDTO
    {
        public int id { get; set; }
        public int? idStudent { get; set; }
        public int? idDepartement { get; set; }


        public studentDepartamentResponseDTO Mapper(studentDepartamentResponseDTO dto, studentDepartament obj)
        {
            dto.id = obj.id;
            dto.idStudent = obj.idStudent;
            dto.idDepartement = obj.idDepartement;
            return dto;
        }
    }
}
