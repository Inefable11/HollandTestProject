using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class parameterDetails
    {
        public int id { get; set; }
        public int? idParameter { get; set; }
        public string code { get; set; }
        public string value_1 { get; set; }
        public string value_2 { get; set; }
        public string value_3 { get; set; }
        public int? sort { get; set; }
        public bool? isActive { get; set; }
    }
}
