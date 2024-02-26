using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel.system_management
{
    public class CredencialesUsuaroBE
    {
        public string username { get; set; }
        public string password { get; set; }
        public int typeLogin { get; set; }
    }
}
