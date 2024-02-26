using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandEmprendedorTeGustariaResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? eT_tomardecisionesqueafectanaotros { get; set; }
        public bool? eT_usarenergiaoconducir { get; set; }
        public bool? eT_dardiscursosocharlas { get; set; }
        public bool? eT_usarhabilidadesenargumentosodebates { get; set; }
        public bool? eT_tomarriesgos { get; set; }
        public bool? eT_organizarydirigiraotros { get; set; }


        public testHollandEmprendedorTeGustariaResponseDTO Mapper(testHollandEmprendedorTeGustariaResponseDTO dto, testHollandEmprendedorTeGustaria obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.eT_tomardecisionesqueafectanaotros = obj.eT_tomardecisionesqueafectanaotros;
            dto.eT_usarenergiaoconducir = obj.eT_usarenergiaoconducir;
            dto.eT_dardiscursosocharlas = obj.eT_dardiscursosocharlas;
            dto.eT_usarhabilidadesenargumentosodebates = obj.eT_usarhabilidadesenargumentosodebates;
            dto.eT_tomarriesgos = obj.eT_tomarriesgos;
            dto.eT_organizarydirigiraotros = obj.eT_organizarydirigiraotros;
            return dto;
        }
    }
}
