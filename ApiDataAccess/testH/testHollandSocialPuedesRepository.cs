using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandSocialPuedesRepository : Repository<testHollandSocialPuedes>, ITesthollandsocialpuedesRepository
    {
        public testHollandSocialPuedesRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
