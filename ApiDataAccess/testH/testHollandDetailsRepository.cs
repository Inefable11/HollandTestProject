using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ApiModel.system_management;
using ApiModel.testH;
using ApiModel._RequestDTO;
using ApiModel._ResponseDTO.testH;
using ApiRepositories.testH;
using Dapper;

namespace ApiDataAccess.testH
{
    public class testHollandDetailsRepository : Repository<testHollandDetails>, ITesthollanddetailsRepository
    {
        public testHollandDetailsRepository(string _connectionString) : base(_connectionString)
        {
        }

        public IEnumerable<testDetailResponse> GetTestDetail(testDetailRequestDTO testDetailRequestDto)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@name", testDetailRequestDto.name == null ? "" : testDetailRequestDto.name);
            parameters.Add("@fechaResolucionIni", testDetailRequestDto.fechaResolucionIni.ToString() == "" ? (object) DateTime.MinValue.ToString("yyyy-MM-dd") : testDetailRequestDto.fechaResolucionIni);
            parameters.Add("@fechaResolucionFin", testDetailRequestDto.fechaResolucionFin.ToString() == "" ? (object)DateTime.Now.ToString("yyyy-MM-dd") : testDetailRequestDto.fechaResolucionFin);
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<testDetailResponse>("[dbo].[sp_GetTestDetail]", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public testHollandDetailsChart GetTestChart(in int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<testHollandDetailsChart>("[dbo].[sp_GetTestChart]", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            }
        }
    }
}
