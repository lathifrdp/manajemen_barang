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
    
    public partial class spGetBarangKeluar_Result
    {
        public int id_barang_keluar { get; set; }
        public int id_barang { get; set; }
        public System.DateTime tanggal_keluar { get; set; }
        public int jum_barang_keluar { get; set; }
        public string deskripsi { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> updated_by { get; set; }
    }
}