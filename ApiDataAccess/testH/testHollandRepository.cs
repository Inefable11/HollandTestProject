using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandRepository : Repository<testHolland>, ITesthollandRepository
    {
        public testHollandRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
