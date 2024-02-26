using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandConvencionalPuedesRepository : Repository<testHollandConvencionalPuedes>, ITesthollandconvencionalpuedesRepository
    {
        public testHollandConvencionalPuedesRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
