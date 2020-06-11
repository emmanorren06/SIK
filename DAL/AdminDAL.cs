

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
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
        public Admin CekLogin(string username, string password)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Admin where
                username=@username and password=@password";
                var param = new {username=username, password=GetMd5(password)
                };
                var data = conn.QuerySingleOrDefault<Admin>(strSql,param);
                if(data!=null){
                    return data;
                }
                else{
                    throw new Exception("username atau password salah");
                }
            }
        }

        public void Delete(Admin adm)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Insert(Admin adm)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"set identity_insert Admin off; insert into Admin( username,password) 
                values(@username, @password)";
                var param = new {id_admin = adm.id_admin, 
                username = adm.username, password = GetMd5 (adm.password)};

                try{
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Admin adm)
        {
            throw new NotImplementedException();
        }

        private string GetMd5(string input){
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}