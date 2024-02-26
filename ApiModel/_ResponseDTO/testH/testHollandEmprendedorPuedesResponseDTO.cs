using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandEmprendedorPuedesResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? eP_iniciarproyectos { get; set; }
        public bool? eP_convenceralagentedehacercosas { get; set; }
        public bool? eP_vendercosasopromoverideas { get; set; }
        public bool? eP_darcharlasodiscursos { get; set; }
        public bool? eP_organizaractividadesyeventos { get; set; }
        public bool? eP_dirigirungrupo { get; set; }


        public testHollandEmprendedorPuedesResponseDTO Mapper(testHollandEmprendedorPuedesResponseDTO dto, testHollandEmprendedorPuedes obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.eP_iniciarproyectos = obj.eP_iniciarproyectos;
            dto.eP_convenceralagentedehacercosas = obj.eP_convenceralagentedehacercosas;
            dto.eP_vendercosasopromoverideas = obj.eP_vendercosasopromoverideas;
            dto.eP_darcharlasodiscursos = obj.eP_darcharlasodiscursos;
            dto.eP_organizaractividadesyeventos = obj.eP_organizaractividadesyeventos;
            dto.eP_dirigirungrupo = obj.eP_dirigirungrupo;
            return dto;
        }
    }
}
