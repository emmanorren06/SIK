// using SIK.Models;


using System.Collections.Generic;
using SIK.Models;

namespace SIK.DAL 
{
    public interface IAdmin
    {
        IEnumerable<Admin> GetAllAdmin();
        Admin GetByID(string id_admin);
        void Insert(Admin adm);
        void Update(Admin adm);
        void Delete(Admin adm);
        
    }
    
}