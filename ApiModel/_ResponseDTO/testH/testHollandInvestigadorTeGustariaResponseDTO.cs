using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandInvestigadorTeGustariaResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? iT_explorarideas { get; set; }
        public bool? iT_usarcomputadoras { get; set; }
        public bool? iT_trabajarindependientemente { get; set; }
        public bool? iT_realizarexperimentosdelaboratorio { get; set; }
        public bool? iT_leerrevistascientificasotecnicas { get; set; }
        public bool? iT_analizardatos { get; set; }


        public testHollandInvestigadorTeGustariaResponseDTO Mapper(testHollandInvestigadorTeGustariaResponseDTO dto, testHollandInvestigadorTeGustaria obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.iT_explorarideas = obj.iT_explorarideas;
            dto.iT_usarcomputadoras = obj.iT_usarcomputadoras;
            dto.iT_trabajarindependientemente = obj.iT_trabajarindependientemente;
            dto.iT_realizarexperimentosdelaboratorio = obj.iT_realizarexperimentosdelaboratorio;
            dto.iT_leerrevistascientificasotecnicas = obj.iT_leerrevistascientificasotecnicas;
            dto.iT_analizardatos = obj.iT_analizardatos;
            return dto;
        }
    }
}
