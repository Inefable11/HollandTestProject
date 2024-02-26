using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandEmprendedorPuedesRepository : Repository<testHollandEmprendedorPuedes>, ITesthollandemprendedorpuedesRepository
    {
        public testHollandEmprendedorPuedesRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
