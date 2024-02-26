using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandInvestigadorPuedesRepository : Repository<testHollandInvestigadorPuedes>, ITesthollandinvestigadorpuedesRepository
    {
        public testHollandInvestigadorPuedesRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
