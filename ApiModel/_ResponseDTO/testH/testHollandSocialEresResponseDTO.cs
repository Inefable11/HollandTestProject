using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandSocialEresResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? sE_amigable { get; set; }
        public bool? sE_util { get; set; }
        public bool? sE_idealista { get; set; }
        public bool? sE_perspicazacercadelaspersonas { get; set; }
        public bool? sE_extrovertidoconlosdemas { get; set; }
        public bool? sE_comprensivo { get; set; }


        public testHollandSocialEresResponseDTO Mapper(testHollandSocialEresResponseDTO dto, testHollandSocialEres obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.sE_amigable = obj.sE_amigable;
            dto.sE_util = obj.sE_util;
            dto.sE_idealista = obj.sE_idealista;
            dto.sE_perspicazacercadelaspersonas = obj.sE_perspicazacercadelaspersonas;
            dto.sE_extrovertidoconlosdemas = obj.sE_extrovertidoconlosdemas;
            dto.sE_comprensivo = obj.sE_comprensivo;
            return dto;
        }
    }
}
