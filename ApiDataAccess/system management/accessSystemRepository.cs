using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ApiModel.system_management;
using ApiRepositories.system_management;
using Dapper;

namespace ApiDataAccess.system_management
{
    public class accessSystemRepository : Repository<accessSystem>, IAccesssystemRepository
    {
        public accessSystemRepository(string _connectionString) : base(_connectionString)
        {
        }

        public staff LoguearUsuarioStaff(CredencialesUsuaroBE usuario)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@username", usuario.username);
            parameters.Add("@password", usuario.password);
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<staff>("[dbo].[sp_accessSystemStaff]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public teachers LoguearUsuarioTeacher(CredencialesUsuaroBE usuario)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@username", usuario.username);
            parameters.Add("@password", usuario.password);
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<teachers>("[dbo].[sp_accessSystemTeacher]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public students LoguearUsuarioStudent(CredencialesUsuaroBE usuario)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@username", usuario.username);
            parameters.Add("@password", usuario.password);
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<students>("[dbo].[sp_accessSystemStudent]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public accessSystem GetByUpdate(in int objId, in int i)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUser", objId);
            parameters.Add("@userType", i);
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<accessSystem>("[dbo].[sp_GetByUpdate]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public bool deleteAccesos(string username)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@username", username);
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = connection.Query<int>("[dbo].[sp_deleteAccesos]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return (result == 1);
            }
        }
    }
}
