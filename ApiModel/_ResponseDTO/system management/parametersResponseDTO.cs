using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class parametersResponseDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }


        public parametersResponseDTO Mapper(parametersResponseDTO dto, parameters obj)
        {
            dto.id = obj.id;
            dto.name = obj.name;
            dto.code = obj.code;
            dto.description = obj.description;
            return dto;
        }
    }
}
