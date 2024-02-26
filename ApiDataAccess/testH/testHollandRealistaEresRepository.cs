using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandRealistaEresRepository : Repository<testHollandRealistaEres>, ITesthollandrealistaeresRepository
    {
        public testHollandRealistaEresRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
