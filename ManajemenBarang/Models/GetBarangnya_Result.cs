//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManajemenBarang.Models
{
    using System;
    
    public partial class GetBarangnya_Result
    {
        public int id_barang { get; set; }
        public int id_kategori { get; set; }
        public string nama_barang { get; set; }
        public string kode_barang { get; set; }
        public Nullable<int> id_supplier { get; set; }
        public int jumlah_barang { get; set; }
    }
}
