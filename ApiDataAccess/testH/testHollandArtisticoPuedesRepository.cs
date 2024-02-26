using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandArtisticoPuedesRepository : Repository<testHollandArtisticoPuedes>, ITesthollandartisticopuedesRepository
    {
        public testHollandArtisticoPuedesRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
