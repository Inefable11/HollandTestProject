using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.system_management;
using ApiRepositories.system_management;

namespace ApiDataAccess.system_management
{
    public class studyInstitutionsRepository : Repository<studyInstitutions>, IStudyinstitutionsRepository
    {
        public studyInstitutionsRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
