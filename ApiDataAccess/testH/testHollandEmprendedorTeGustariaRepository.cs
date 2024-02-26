using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandEmprendedorTeGustariaRepository : Repository<testHollandEmprendedorTeGustaria>, ITesthollandemprendedortegustariaRepository
    {
        public testHollandEmprendedorTeGustariaRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
