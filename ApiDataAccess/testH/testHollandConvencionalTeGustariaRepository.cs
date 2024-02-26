using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandConvencionalTeGustariaRepository : Repository<testHollandConvencionalTeGustaria>, ITesthollandconvencionaltegustariaRepository
    {
        public testHollandConvencionalTeGustariaRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
