using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandInvestigadorPuedesResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? iP_pensardeformaabstracta { get; set; }
        public bool? iP_resolverproblemasmatematicos { get; set; }
        public bool? iP_entenderteoriasfisicas { get; set; }
        public bool? iP_hacercalculoscomplejos { get; set; }
        public bool? iP_usarunmicroscopio { get; set; }
        public bool? iP_interpretarformulas { get; set; }


        public testHollandInvestigadorPuedesResponseDTO Mapper(testHollandInvestigadorPuedesResponseDTO dto, testHollandInvestigadorPuedes obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.iP_pensardeformaabstracta = obj.iP_pensardeformaabstracta;
            dto.iP_resolverproblemasmatematicos = obj.iP_resolverproblemasmatematicos;
            dto.iP_entenderteoriasfisicas = obj.iP_entenderteoriasfisicas;
            dto.iP_hacercalculoscomplejos = obj.iP_hacercalculoscomplejos;
            dto.iP_usarunmicroscopio = obj.iP_usarunmicroscopio;
            dto.iP_interpretarformulas = obj.iP_interpretarformulas;
            return dto;
        }
    }
}
