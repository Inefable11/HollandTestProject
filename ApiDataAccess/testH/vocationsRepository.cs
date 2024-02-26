using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;
using ApiRepositories.testH;

namespace ApiDataAccess.testH
{
    public class vocationsRepository : Repository<vocations>, IVocationsRepository
    {
        public vocationsRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
