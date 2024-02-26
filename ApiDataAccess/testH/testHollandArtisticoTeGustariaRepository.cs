using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandArtisticoTeGustariaRepository : Repository<testHollandArtisticoTeGustaria>, ITesthollandartisticotegustariaRepository
    {
        public testHollandArtisticoTeGustariaRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
