using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class staff
    {
        public int id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime? date { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string designation { get; set; }
    }
}
