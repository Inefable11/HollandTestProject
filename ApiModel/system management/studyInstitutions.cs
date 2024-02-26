using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class studyInstitutions
    {
        public int id { get; set; }
        public string name { get; set; }
        public string studyCareers { get; set; }
        public string description { get; set; }
        public string details { get; set; }
        public string img { get; set; }
        public bool? isActive { get; set; }
        public string url { get; set; }
    }
}
