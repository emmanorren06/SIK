
// using System.ComponentModel.DataAnnotations;

namespace SIK.Models{
    public class Aktiva
    {
        public string id_aktiva {get; set;}
        public string id_kategori {get; set;}
        public string nama_aktiva {get; set;}
        public string tgl_pembelian {get; set;}
        public string tahun_penyusutan {get; set;}
        public string harga_perolehan {get; set;}
        public string residu {get; set;}
    }
}