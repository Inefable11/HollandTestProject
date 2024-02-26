using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandSocialPuedesResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? sP_ensenaroentrenaraotros { get; set; }
        public bool? sP_expresarsussentimientosconclaridad { get; set; }
        public bool? sP_dirigirunadiscusionengrupo { get; set; }
        public bool? sP_mediarenlasdisputas { get; set; }
        public bool? sP_cooperabienconlosdemas { get; set; }
        public bool? sP_trabajabienengruposoequipos { get; set; }


        public testHollandSocialPuedesResponseDTO Mapper(testHollandSocialPuedesResponseDTO dto, testHollandSocialPuedes obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.sP_ensenaroentrenaraotros = obj.sP_ensenaroentrenaraotros;
            dto.sP_expresarsussentimientosconclaridad = obj.sP_expresarsussentimientosconclaridad;
            dto.sP_dirigirunadiscusionengrupo = obj.sP_dirigirunadiscusionengrupo;
            dto.sP_mediarenlasdisputas = obj.sP_mediarenlasdisputas;
            dto.sP_cooperabienconlosdemas = obj.sP_cooperabienconlosdemas;
            dto.sP_trabajabienengruposoequipos = obj.sP_trabajabienengruposoequipos;
            return dto;
        }
    }
}
