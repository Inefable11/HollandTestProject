using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandConvencionalPuedesResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? cP_trabajarbiendentrodeunaautoridad { get; set; }
        public bool? cP_escribirreportes { get; set; }
        public bool? cP_mantenerregistrosprecisos { get; set; }
        public bool? cP_usarunaterminaldecomputadora { get; set; }
        public bool? cP_realizarcalculos { get; set; }
        public bool? cP_reunirorganizaryreportardatos { get; set; }


        public testHollandConvencionalPuedesResponseDTO Mapper(testHollandConvencionalPuedesResponseDTO dto, testHollandConvencionalPuedes obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.cP_trabajarbiendentrodeunaautoridad = obj.cP_trabajarbiendentrodeunaautoridad;
            dto.cP_escribirreportes = obj.cP_escribirreportes;
            dto.cP_mantenerregistrosprecisos = obj.cP_mantenerregistrosprecisos;
            dto.cP_usarunaterminaldecomputadora = obj.cP_usarunaterminaldecomputadora;
            dto.cP_realizarcalculos = obj.cP_realizarcalculos;
            dto.cP_reunirorganizaryreportardatos = obj.cP_reunirorganizaryreportardatos;
            return dto;
        }
    }
}
