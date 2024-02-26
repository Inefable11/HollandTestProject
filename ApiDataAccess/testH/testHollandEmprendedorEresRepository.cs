using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandEmprendedorEresRepository : Repository<testHollandEmprendedorEres>, ITesthollandemprendedoreresRepository
    {
        public testHollandEmprendedorEresRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
