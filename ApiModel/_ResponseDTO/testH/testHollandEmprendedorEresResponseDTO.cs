using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandEmprendedorEresResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? eE_segurodesimismo { get; set; }
        public bool? eE_asertivo { get; set; }
        public bool? eE_sociable { get; set; }
        public bool? eE_persuasivo { get; set; }
        public bool? eE_entusiasta { get; set; }
        public bool? eE_energetico { get; set; }


        public testHollandEmprendedorEresResponseDTO Mapper(testHollandEmprendedorEresResponseDTO dto, testHollandEmprendedorEres obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.eE_segurodesimismo = obj.eE_segurodesimismo;
            dto.eE_asertivo = obj.eE_asertivo;
            dto.eE_sociable = obj.eE_sociable;
            dto.eE_persuasivo = obj.eE_persuasivo;
            dto.eE_entusiasta = obj.eE_entusiasta;
            dto.eE_energetico = obj.eE_energetico;
            return dto;
        }
    }
}
