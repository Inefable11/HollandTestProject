using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class studyCareers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string jobProfile { get; set; }
        public string workField { get; set; }
        public string img { get; set; }
        public bool? isActive { get; set; }
    }
}
