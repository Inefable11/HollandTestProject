using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class teacherDepartamentResponseDTO
    {
        public int id { get; set; }
        public int? idTeacher { get; set; }
        public int? idDepartament { get; set; }


        public teacherDepartamentResponseDTO Mapper(teacherDepartamentResponseDTO dto, teacherDepartament obj)
        {
            dto.id = obj.id;
            dto.idTeacher = obj.idTeacher;
            dto.idDepartament = obj.idDepartament;
            return dto;
        }
    }
}
