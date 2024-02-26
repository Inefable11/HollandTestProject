using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandInvestigadorTeGustariaRepository : Repository<testHollandInvestigadorTeGustaria>, ITesthollandinvestigadortegustariaRepository
    {
        public testHollandInvestigadorTeGustariaRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
