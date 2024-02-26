using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandInvestigadorEresRepository : Repository<testHollandInvestigadorEres>, ITesthollandinvestigadoreresRepository
    {
        public testHollandInvestigadorEresRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
