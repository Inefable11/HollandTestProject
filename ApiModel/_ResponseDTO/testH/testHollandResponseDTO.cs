using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandResponseDTO
    {
        public int id { get; set; }
        public int? idStudent { get; set; }
        public DateTime? fechaAsignacion { get; set; }
        public DateTime? fechaResolucion { get; set; }
        public string horaInicio { get; set; }
        public string horaFin { get; set; }


        public testHollandResponseDTO Mapper(testHollandResponseDTO dto, testHolland obj)
        {
            dto.id = obj.id;
            dto.idStudent = obj.idStudent;
            dto.fechaAsignacion = obj.fechaAsignacion;
            dto.fechaResolucion = obj.fechaResolucion;
            dto.horaInicio = obj.horaInicio;
            dto.horaFin = obj.horaFin;
            return dto;
        }
    }
}
