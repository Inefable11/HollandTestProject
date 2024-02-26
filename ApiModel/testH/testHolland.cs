using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.testH
{
    public class testHolland
    {
        public int id { get; set; }
        public int? idStudent { get; set; }
        public DateTime? fechaAsignacion { get; set; }
        public DateTime? fechaResolucion { get; set; }
        public string horaInicio { get; set; }
        public string horaFin { get; set; }
    }
}
