using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class teachersResponseDTO
    {
        public int id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime? date { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string department { get; set; }
        public string degree { get; set; }


        public teachersResponseDTO Mapper(teachersResponseDTO dto, teachers obj)
        {
            dto.id = obj.id;
            dto.img = obj.img;
            dto.name = obj.name;
            dto.email = obj.email;
            dto.date = obj.date;
            dto.gender = obj.gender;
            dto.mobile = obj.mobile;
            dto.department = obj.department;
            dto.degree = obj.degree;
            return dto;
        }
    }
}
