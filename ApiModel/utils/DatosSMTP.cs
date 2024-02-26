using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.utils
{
    public class DatosSMTP
    {
        public string Servidor { get; set; }
        public int Puerto { get; set; }
        public bool CredencialesPorDefecto { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
