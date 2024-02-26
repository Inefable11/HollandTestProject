using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;
using ApiRepositories.system_management;

namespace ApiDataAccess.system_management
{
    public class studyCareersRepository : Repository<studyCareers>, IStudycareersRepository
    {
        public studyCareersRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
