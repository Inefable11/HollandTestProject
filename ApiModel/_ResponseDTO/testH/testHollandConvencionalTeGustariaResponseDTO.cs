using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandConvencionalTeGustariaResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? cT_seguirprocedimientosdefinidos { get; set; }
        public bool? cT_hacercuadrostablasygraficos { get; set; }
        public bool? cT_trabajarconnumeros { get; set; }
        public bool? cT_escribiramaquinaoprocesartextos { get; set; }
        public bool? cT_clasificaryorganizarinformacion { get; set; }
        public bool? cT_serresponsabledelosdetalles { get; set; }


        public testHollandConvencionalTeGustariaResponseDTO Mapper(testHollandConvencionalTeGustariaResponseDTO dto, testHollandConvencionalTeGustaria obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.cT_seguirprocedimientosdefinidos = obj.cT_seguirprocedimientosdefinidos;
            dto.cT_hacercuadrostablasygraficos = obj.cT_hacercuadrostablasygraficos;
            dto.cT_trabajarconnumeros = obj.cT_trabajarconnumeros;
            dto.cT_escribiramaquinaoprocesartextos = obj.cT_escribiramaquinaoprocesartextos;
            dto.cT_clasificaryorganizarinformacion = obj.cT_clasificaryorganizarinformacion;
            dto.cT_serresponsabledelosdetalles = obj.cT_serresponsabledelosdetalles;
            return dto;
        }
    }
}
