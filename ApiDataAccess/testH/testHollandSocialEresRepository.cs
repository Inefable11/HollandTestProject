using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandSocialEresRepository : Repository<testHollandSocialEres>, ITesthollandsocialeresRepository
    {
        public testHollandSocialEresRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
