using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandRealistaPuedesResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? rP_arreglarcosaselectricas { get; set; }
        public bool? rP_resolverproblemasmecanicos { get; set; }
        public bool? rP_armarunacarpa { get; set; }
        public bool? rP_jugarundeporte { get; set; }
        public bool? rP_leerunplano { get; set; }
        public bool? rP_operarherramientasymaquinaria { get; set; }


        public testHollandRealistaPuedesResponseDTO Mapper(testHollandRealistaPuedesResponseDTO dto, testHollandRealistaPuedes obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.rP_arreglarcosaselectricas = obj.rP_arreglarcosaselectricas;
            dto.rP_resolverproblemasmecanicos = obj.rP_resolverproblemasmecanicos;
            dto.rP_armarunacarpa = obj.rP_armarunacarpa;
            dto.rP_jugarundeporte = obj.rP_jugarundeporte;
            dto.rP_leerunplano = obj.rP_leerunplano;
            dto.rP_operarherramientasymaquinaria = obj.rP_operarherramientasymaquinaria;
            return dto;
        }
    }
}
