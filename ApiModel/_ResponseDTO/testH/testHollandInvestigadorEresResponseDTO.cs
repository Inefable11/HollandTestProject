using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandInvestigadorEresResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? iE_investigadordetalloso { get; set; }
        public bool? iE_analitico { get; set; }
        public bool? iE_cientifico { get; set; }
        public bool? iE_observador { get; set; }
        public bool? iE_logico { get; set; }
        public bool? iE_preciso { get; set; }


        public testHollandInvestigadorEresResponseDTO Mapper(testHollandInvestigadorEresResponseDTO dto, testHollandInvestigadorEres obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.iE_investigadordetalloso = obj.iE_investigadordetalloso;
            dto.iE_analitico = obj.iE_analitico;
            dto.iE_cientifico = obj.iE_cientifico;
            dto.iE_observador = obj.iE_observador;
            dto.iE_logico = obj.iE_logico;
            dto.iE_preciso = obj.iE_preciso;
            return dto;
        }
    }
}
