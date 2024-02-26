using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class accessSystem
    {
        public int id { get; set; }
        public int? idUser { get; set; }
        public int? userType { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
