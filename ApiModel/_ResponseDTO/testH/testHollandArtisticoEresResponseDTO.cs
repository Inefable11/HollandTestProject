using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandArtisticoEresResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? aE_creativo { get; set; }
        public bool? aE_intuitivo { get; set; }
        public bool? aE_imaginativo { get; set; }
        public bool? aE_innovador { get; set; }
        public bool? aE_sensible { get; set; }
        public bool? aE_unindividualista { get; set; }


        public testHollandArtisticoEresResponseDTO Mapper(testHollandArtisticoEresResponseDTO dto, testHollandArtisticoEres obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.aE_creativo = obj.aE_creativo;
            dto.aE_intuitivo = obj.aE_intuitivo;
            dto.aE_imaginativo = obj.aE_imaginativo;
            dto.aE_innovador = obj.aE_innovador;
            dto.aE_sensible = obj.aE_sensible;
            dto.aE_unindividualista = obj.aE_unindividualista;
            return dto;
        }
    }
}
