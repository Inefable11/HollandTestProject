using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandArtisticoTeGustariaResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? aT_resolverproblemasdemaneraoriginal { get; set; }
        public bool? aT_leerficcionobrasdeteatropoesia { get; set; }
        public bool? aT_usarhabilidadesverbalesparahablaractuarentretener { get; set; }
        public bool? aT_tomarfotografias { get; set; }
        public bool? aT_usarhabilidadesdevisualizacion { get; set; }
        public bool? aT_expresarsecreativamente { get; set; }


        public testHollandArtisticoTeGustariaResponseDTO Mapper(testHollandArtisticoTeGustariaResponseDTO dto, testHollandArtisticoTeGustaria obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.aT_resolverproblemasdemaneraoriginal = obj.aT_resolverproblemasdemaneraoriginal;
            dto.aT_leerficcionobrasdeteatropoesia = obj.aT_leerficcionobrasdeteatropoesia;
            dto.aT_usarhabilidadesverbalesparahablaractuarentretener = obj.aT_usarhabilidadesverbalesparahablaractuarentretener;
            dto.aT_tomarfotografias = obj.aT_tomarfotografias;
            dto.aT_usarhabilidadesdevisualizacion = obj.aT_usarhabilidadesdevisualizacion;
            dto.aT_expresarsecreativamente = obj.aT_expresarsecreativamente;
            return dto;
        }
    }
}
