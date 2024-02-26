using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandRealistaEresResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? rE_practico { get; set; }
        public bool? rE_atletico { get; set; }
        public bool? rE_directo { get; set; }
        public bool? rE_inclinadoalamecanica { get; set; }
        public bool? rE_amantedelanaturaleza { get; set; }
        public bool? rE_curiososobreelmundofisico { get; set; }


        public testHollandRealistaEresResponseDTO Mapper(testHollandRealistaEresResponseDTO dto, testHollandRealistaEres obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.rE_practico = obj.rE_practico;
            dto.rE_atletico = obj.rE_atletico;
            dto.rE_directo = obj.rE_directo;
            dto.rE_inclinadoalamecanica = obj.rE_inclinadoalamecanica;
            dto.rE_amantedelanaturaleza = obj.rE_amantedelanaturaleza;
            dto.rE_curiososobreelmundofisico = obj.rE_curiososobreelmundofisico;
            return dto;
        }
    }
}
