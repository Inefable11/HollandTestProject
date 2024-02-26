using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandArtisticoPuedesResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? aP_bosquejardibujarpintar { get; set; }
        public bool? aP_usarlaintuicion { get; set; }
        public bool? aP_tocaruninstrumentomusical { get; set; }
        public bool? aP_escribirhistoriaspoesiamusica { get; set; }
        public bool? aP_desarrollarnuevasideasenfoques { get; set; }
        public bool? aP_disenarmodasointeriores { get; set; }


        public testHollandArtisticoPuedesResponseDTO Mapper(testHollandArtisticoPuedesResponseDTO dto, testHollandArtisticoPuedes obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.aP_bosquejardibujarpintar = obj.aP_bosquejardibujarpintar;
            dto.aP_usarlaintuicion = obj.aP_usarlaintuicion;
            dto.aP_tocaruninstrumentomusical = obj.aP_tocaruninstrumentomusical;
            dto.aP_escribirhistoriaspoesiamusica = obj.aP_escribirhistoriaspoesiamusica;
            dto.aP_desarrollarnuevasideasenfoques = obj.aP_desarrollarnuevasideasenfoques;
            dto.aP_disenarmodasointeriores = obj.aP_disenarmodasointeriores;
            return dto;
        }
    }
}
