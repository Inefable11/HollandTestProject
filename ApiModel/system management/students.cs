using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class students
    {
        public int id { get; set; }
        public string studentCode { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime? dateJoin { get; set; }
        public DateTime? dateBirth { get; set; }
        public string parentsName { get; set; }
        public string parentsPhone { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public int department { get; set; }
        public string bloodGroup { get; set; }
        public string address { get; set; }
        public string rollNo { get; set; }
    }
}
