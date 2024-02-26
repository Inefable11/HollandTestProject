using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class studentsResponseDTO
    {
        public int id { get; set; }
        public string studentCode { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime? dateJoin { get; set; }
        public DateTime? dateBirth { get; set; }
        public string parentsName { get; set; }
        public string parentsPhone { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public int department { get; set; }
        public string bloodGroup { get; set; }
        public string address { get; set; }
        public string rollNo { get; set; }


        public studentsResponseDTO Mapper(studentsResponseDTO dto, students obj)
        {
            dto.id = obj.id;
            dto.studentCode = obj.studentCode;
            dto.img = obj.img;
            dto.name = obj.name;
            dto.email = obj.email;
            dto.dateJoin = obj.dateJoin;
            dto.dateBirth = obj.dateBirth;
            dto.parentsName = obj.parentsName;
            dto.parentsPhone = obj.parentsPhone;
            dto.gender = obj.gender;
            dto.mobile = obj.mobile;
            dto.department = obj.department;
            dto.bloodGroup = obj.bloodGroup;
            dto.address = obj.address;
            dto.rollNo = obj.rollNo;
            return dto;
        }
    }
}
