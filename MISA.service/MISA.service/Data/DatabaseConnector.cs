using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.service.Data
{
    public class DatabaseConnector<TEntity>
    {
        static string connectionString = "Host = 127.0.0.1; Port = 3306;Database = lvdat_misa_cukcuk; User Id = root ;Password = luudet0512ld;Character Set=utf8";
                            
        string className = typeof(TEntity).Name;
        IDbConnection _bConnection;

        public DatabaseConnector()
        {
            _bConnection = new MySqlConnection(connectionString);
        }
        public IEnumerable<TEntity> GetAll()
        {
            var className = typeof(TEntity).Name;
            
            
            var sql = $"select * from {className} limit 20";
            var data = _bConnection.Query<TEntity>(sql).ToList();
            return data;
        }
    }
}
