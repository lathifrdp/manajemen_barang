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
    
    public partial class GetBarangSup21_Result
    {
        public int id_barang { get; set; }
        public int id_kategori { get; set; }
        public Nullable<int> id_supplier { get; set; }
        public string kode_barang { get; set; }
        public string nama_barang { get; set; }
        public int jumlah_barang { get; set; }
        public Nullable<int> kategori_id { get; set; }
        public string nama_kategori { get; set; }
        public string deskripsi { get; set; }
        public Nullable<int> id_barang_masuk { get; set; }
        public Nullable<System.DateTime> tanggal_masuk { get; set; }
        public Nullable<int> jum_barang_masuk { get; set; }
        public Nullable<int> created_masuk { get; set; }
        public Nullable<int> updated_masuk { get; set; }
        public Nullable<int> id_barang_keluar { get; set; }
        public Nullable<System.DateTime> tanggal_keluar { get; set; }
        public Nullable<int> jum_barang_keluar { get; set; }
        public Nullable<int> created_keluar { get; set; }
        public Nullable<int> updated_keluar { get; set; }
        public Nullable<int> id_barang_return { get; set; }
        public Nullable<System.DateTime> tanggal_return { get; set; }
        public Nullable<int> jum_barang_return { get; set; }
        public Nullable<int> created_return { get; set; }
        public Nullable<int> created_return1 { get; set; }
    }
}
