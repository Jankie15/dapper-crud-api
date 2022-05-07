using Dapper;
using DapperCRUDAPI.InterfaceDataAccess;
using PracticaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaTecnica.DataAccess.User
{
    public class CustomerDataAccess : IReadDataAccess<CustomerModel>, IWriteDataAccess<CustomerModel>

    {
        private string connectionString;
        public CustomerDataAccess()
        {
            connectionString = "Data Source=MSI-GF63-THIN;Initial Catalog=DB_PracticaTecnica;User ID=root;Password=1234;";
        }    

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        async Task IWriteDataAccess<CustomerModel>.Add(CustomerModel user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"INSERT INTO CustomerTable(Name, PhoneNumber, Email, Notes, State) VALUES (@Name, @PhoneNumber, @Email, @Notes, @State)";
                dbConnection.Open();
                await dbConnection.ExecuteAsync(query, user);
            }
        }

        async Task IWriteDataAccess<CustomerModel>.Delete(Guid id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"DELETE FROM CustomerTable WHERE Id = @Id";
                dbConnection.Open();
                await dbConnection.ExecuteAsync(query, new { Id = id });
            }
        }   

        async Task<IEnumerable<CustomerModel>> IReadDataAccess<CustomerModel>.GetAll(int Offset, int Limit)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"SELECT * FROM [DB_PracticaTecnica].[dbo].[CustomerTable] ORDER BY (RegisterNumber) OFFSET @OFFSET ROWS FETCH NEXT @LIMIT ROWS ONLY;";
                dbConnection.Open();       
               IEnumerable<CustomerModel> result = await dbConnection.QueryAsync<CustomerModel>(query, new { OFFSET = Offset, LIMIT = Limit });
               return result;
            }
        }

        async Task<CustomerModel> IReadDataAccess<CustomerModel>.GetById(Guid id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"SELECT * FROM CustomerTable WHERE Id = @Id";
                dbConnection.Open();
                CustomerModel result = (await dbConnection.QueryAsync<CustomerModel>(query, new { Id = id })).FirstOrDefault();
                return result;
            }
        }
    }
}
