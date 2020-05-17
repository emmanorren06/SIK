


using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using SIK.Models;

namespace SIK.DAL
{
    public class AktivaDAL : IAktiva
    {
        private IConfiguration _config;

        public AktivaDAL(IConfiguration config)
        {
            _config = config;
        }
        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public void Delete(Aktiva akt)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Aktiva> GetAllAktiva()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Aktiva order by nama_aktiva";
                return conn.Query<Aktiva>(strSql);
            }
        }

        public Aktiva GetByid(string id_aktiva)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Aktiva akt)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Aktiva akt)
        {
            throw new System.NotImplementedException();
        }
    }
}