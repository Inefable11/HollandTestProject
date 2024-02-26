using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandSocialTeGustariaRepository : Repository<testHollandSocialTeGustaria>, ITesthollandsocialtegustariaRepository
    {
        public testHollandSocialTeGustariaRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
