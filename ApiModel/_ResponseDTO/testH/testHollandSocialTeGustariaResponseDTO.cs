using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandSocialTeGustariaResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? sT_usarhabilidadessocialeseinterpersonales { get; set; }
        public bool? sT_ayudaralaspersonasconsusproblemas { get; set; }
        public bool? sT_dirigirgrupos { get; set; }
        public bool? sT_usarhabilidadesdecomunicacion { get; set; }
        public bool? sT_ensenarocapacitaraotros { get; set; }
        public bool? sT_brindarapoyoempatia { get; set; }


        public testHollandSocialTeGustariaResponseDTO Mapper(testHollandSocialTeGustariaResponseDTO dto, testHollandSocialTeGustaria obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.sT_usarhabilidadessocialeseinterpersonales = obj.sT_usarhabilidadessocialeseinterpersonales;
            dto.sT_ayudaralaspersonasconsusproblemas = obj.sT_ayudaralaspersonasconsusproblemas;
            dto.sT_dirigirgrupos = obj.sT_dirigirgrupos;
            dto.sT_usarhabilidadesdecomunicacion = obj.sT_usarhabilidadesdecomunicacion;
            dto.sT_ensenarocapacitaraotros = obj.sT_ensenarocapacitaraotros;
            dto.sT_brindarapoyoempatia = obj.sT_brindarapoyoempatia;
            return dto;
        }
    }
}
