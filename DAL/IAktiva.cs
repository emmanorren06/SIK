// using SIK.Models;

using System.Collections.Generic;
using SIK.Models;

namespace SIK.DAL
{
    public interface IAktiva
    {
        IEnumerable<Aktiva> GetAllAktiva();
        Aktiva GetByid(string id_aktiva);
        void Insert(Aktiva akt);
        void Update(Aktiva akt);
        void Delete(Aktiva akt);
        
    }
}