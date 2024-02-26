using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class testHollandRealistaTeGustariaRepository : Repository<testHollandRealistaTeGustaria>, ITesthollandrealistategustariaRepository
    {
        public testHollandRealistaTeGustariaRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
