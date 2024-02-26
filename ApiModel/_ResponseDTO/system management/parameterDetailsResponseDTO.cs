using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;

namespace ApiModel._ResponseDTO.system_management
{
    public class parameterDetailsResponseDTO
    {
        public int id { get; set; }
        public int? idParameter { get; set; }
        public string code { get; set; }
        public string value_1 { get; set; }
        public string value_2 { get; set; }
        public string value_3 { get; set; }
        public int? sort { get; set; }
        public bool? isActive { get; set; }


        public parameterDetailsResponseDTO Mapper(parameterDetailsResponseDTO dto, parameterDetails obj)
        {
            dto.id = obj.id;
            dto.idParameter = obj.idParameter;
            dto.code = obj.code;
            dto.value_1 = obj.value_1;
            dto.value_2 = obj.value_2;
            dto.value_3 = obj.value_3;
            dto.sort = obj.sort;
            dto.isActive = obj.isActive;
            return dto;
        }
    }
}
