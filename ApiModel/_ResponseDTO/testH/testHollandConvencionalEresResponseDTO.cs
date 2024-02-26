using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandConvencionalEresResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? cE_bienorganizado { get; set; }
        public bool? cE_precisoconlosdetallesylosnumeros { get; set; }
        public bool? cE_interesadoenprocesarnumeros { get; set; }
        public bool? cE_metodico { get; set; }
        public bool? cE_conscientedeloshechos { get; set; }
        public bool? cE_eficiente { get; set; }


        public testHollandConvencionalEresResponseDTO Mapper(testHollandConvencionalEresResponseDTO dto, testHollandConvencionalEres obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.cE_bienorganizado = obj.cE_bienorganizado;
            dto.cE_precisoconlosdetallesylosnumeros = obj.cE_precisoconlosdetallesylosnumeros;
            dto.cE_interesadoenprocesarnumeros = obj.cE_interesadoenprocesarnumeros;
            dto.cE_metodico = obj.cE_metodico;
            dto.cE_conscientedeloshechos = obj.cE_conscientedeloshechos;
            dto.cE_eficiente = obj.cE_eficiente;
            return dto;
        }
    }
}
