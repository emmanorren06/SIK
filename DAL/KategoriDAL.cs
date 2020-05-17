

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using SIK.Models;

namespace SIK.DAL
{
    public class KategoriDAL : IKategori
    {
        private IConfiguration _config;

        public KategoriDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public void Delete(Kategori ktg)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Kategori> GetAllKategori()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Kateg order by nama_kategori";
                return conn.Query<Kategori>(strSql);
            }
        }

        public Kategori GetByID(string id_kategori)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Kategori ktg)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"insert into Kategori(id_kategori , nama_kategori, umur_ekonomis, metode) 
                values(@id_kategori,@nama_kategori,@umur_ekonomis,@metode)";

                try{
                    var param = new {id_kategori = ktg.id_kategori, nama_kategori = ktg.nama_kategori, umur_ekonomis = ktg.umur_ekonomis, metode = ktg.metode};
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Kategori ktg)
        {
            throw new System.NotImplementedException();
        }
    }
}