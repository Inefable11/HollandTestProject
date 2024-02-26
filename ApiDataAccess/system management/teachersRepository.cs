using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ApiModel.system_management;
using ApiModel._ResponseDTO.testH;
using ApiRepositories.system_management;
using Dapper;

namespace ApiDataAccess.system_management
{
    public class teachersRepository : Repository<teachers>, ITeachersRepository
    {
        public teachersRepository(string _connectionString) : base(_connectionString)
        {
        }

        public IEnumerable<testTeacherGrid> GetTeacherGrid()
        {
            var parameters = new DynamicParameters();
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<testTeacherGrid>("[dbo].[sp_GetTeacherGrid]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public bool validaEmail(string email)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@email", email);
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = connection.Query<int>("[dbo].[sp_validaEmail]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                return (result == 1);
            }
        }
    }
}
