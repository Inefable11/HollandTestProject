using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandRealistaPuedesRepository : Repository<testHollandRealistaPuedes>, ITesthollandrealistapuedesRepository
    {
        public testHollandRealistaPuedesRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
