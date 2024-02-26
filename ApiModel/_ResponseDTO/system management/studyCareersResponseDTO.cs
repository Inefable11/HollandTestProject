using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class studyCareersResponseDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string jobProfile { get; set; }
        public string workField { get; set; }
        public string img { get; set; }
        public bool? isActive { get; set; }


        public studyCareersResponseDTO Mapper(studyCareersResponseDTO dto, studyCareers obj)
        {
            dto.id = obj.id;
            dto.name = obj.name;
            dto.jobProfile = obj.jobProfile;
            dto.workField = obj.workField;
            dto.img = obj.img;
            dto.isActive = obj.isActive;
            return dto;
        }
    }
}
