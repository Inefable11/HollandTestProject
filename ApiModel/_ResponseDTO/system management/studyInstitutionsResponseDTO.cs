using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class studyInstitutionsResponseDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string studyCareers { get; set; }
        public string description { get; set; }
        public string details { get; set; }
        public string img { get; set; }
        public bool? isActive { get; set; }


        public studyInstitutionsResponseDTO Mapper(studyInstitutionsResponseDTO dto, studyInstitutions obj)
        {
            dto.id = obj.id;
            dto.name = obj.name;
            dto.studyCareers = obj.studyCareers;
            dto.description = obj.description;
            dto.details = obj.details;
            dto.img = obj.img;
            dto.isActive = obj.isActive;
            return dto;
        }
    }
}
