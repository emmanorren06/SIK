

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using SIK.Models;

namespace SIK.DAL
{
    public class AdminDAL : IAdmin
    {
        private IConfiguration _config;

        public AdminDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public void Delete(Admin adm)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Admin> GetAllAdmin()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Admin order by username";
                return conn.Query<Admin>(strSql);
            }
        }

        public Admin GetByID(string id_admin)
        {
            throw new System.NotImplementedException();
        }

        
        public void Insert(Admin adm)
        {
            
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"insert into Admin(id_admin, username, password) 
                values(@id_admin,@username,@password)";

                try{
                    var param = new {id_admin = adm.id_admin, username = adm.username, password = adm.password};
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Admin adm)
        {
            throw new System.NotImplementedException();
        }
    }
}