using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandConvencionalEresRepository : Repository<testHollandConvencionalEres>, ITesthollandconvencionaleresRepository
    {
        public testHollandConvencionalEresRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
