

using System.Collections.Generic;
using SIK.Models;

namespace SIK.DAL
{
    public interface IKategori
    {
        IEnumerable<Kategori> GetAllKategori();
        Kategori GetByID(string id_kategori);
        void Insert(Kategori ktg);
        void Update(Kategori ktg);
        void Delete(Kategori ktg);
    }
}