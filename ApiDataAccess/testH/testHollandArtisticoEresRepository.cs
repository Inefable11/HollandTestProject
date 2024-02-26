using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandArtisticoEresRepository : Repository<testHollandArtisticoEres>, ITesthollandartisticoeresRepository
    {
        public testHollandArtisticoEresRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
