using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandRealistaTeGustariaResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public bool? rT_jugarconlasmaquinas { get; set; }
        public bool? rT_trabajaralairelibre { get; set; }
        public bool? rT_serfisicamenteactivo { get; set; }
        public bool? rT_trabajarconlasmanos { get; set; }
        public bool? rT_construircosas { get; set; }
        public bool? rT_trabajarenloscoches { get; set; }


        public testHollandRealistaTeGustariaResponseDTO Mapper(testHollandRealistaTeGustariaResponseDTO dto, testHollandRealistaTeGustaria obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.rT_jugarconlasmaquinas = obj.rT_jugarconlasmaquinas;
            dto.rT_trabajaralairelibre = obj.rT_trabajaralairelibre;
            dto.rT_serfisicamenteactivo = obj.rT_serfisicamenteactivo;
            dto.rT_trabajarconlasmanos = obj.rT_trabajarconlasmanos;
            dto.rT_construircosas = obj.rT_construircosas;
            dto.rT_trabajarenloscoches = obj.rT_trabajarenloscoches;
            return dto;
        }
    }
}
