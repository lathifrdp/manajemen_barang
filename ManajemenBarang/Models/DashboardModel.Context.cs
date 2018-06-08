﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbStokEntities : DbContext
    {
        public dbStokEntities()
            : base("name=dbStokEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Barang> Barangs { get; set; }
        public virtual DbSet<BarangKeluar> BarangKeluars { get; set; }
        public virtual DbSet<BarangMasuk> BarangMasuks { get; set; }
        public virtual DbSet<BarangReturn> BarangReturns { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
    
        public virtual int AddUser(Nullable<int> id_user, string username, string password, Nullable<int> status_user, string nama_supplier, string alamat_supplier, string telp_supplier)
        {
            var id_userParameter = id_user.HasValue ?
                new ObjectParameter("id_user", id_user) :
                new ObjectParameter("id_user", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var status_userParameter = status_user.HasValue ?
                new ObjectParameter("status_user", status_user) :
                new ObjectParameter("status_user", typeof(int));
    
            var nama_supplierParameter = nama_supplier != null ?
                new ObjectParameter("nama_supplier", nama_supplier) :
                new ObjectParameter("nama_supplier", typeof(string));
    
            var alamat_supplierParameter = alamat_supplier != null ?
                new ObjectParameter("alamat_supplier", alamat_supplier) :
                new ObjectParameter("alamat_supplier", typeof(string));
    
            var telp_supplierParameter = telp_supplier != null ?
                new ObjectParameter("telp_supplier", telp_supplier) :
                new ObjectParameter("telp_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", id_userParameter, usernameParameter, passwordParameter, status_userParameter, nama_supplierParameter, alamat_supplierParameter, telp_supplierParameter);
        }
    
        public virtual int AddSupplier(Nullable<int> id_user, string nama_supplier, string alamat_supplier, string telp_supplier)
        {
            var id_userParameter = id_user.HasValue ?
                new ObjectParameter("id_user", id_user) :
                new ObjectParameter("id_user", typeof(int));
    
            var nama_supplierParameter = nama_supplier != null ?
                new ObjectParameter("nama_supplier", nama_supplier) :
                new ObjectParameter("nama_supplier", typeof(string));
    
            var alamat_supplierParameter = alamat_supplier != null ?
                new ObjectParameter("alamat_supplier", alamat_supplier) :
                new ObjectParameter("alamat_supplier", typeof(string));
    
            var telp_supplierParameter = telp_supplier != null ?
                new ObjectParameter("telp_supplier", telp_supplier) :
                new ObjectParameter("telp_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddSupplier", id_userParameter, nama_supplierParameter, alamat_supplierParameter, telp_supplierParameter);
        }
    
        public virtual ObjectResult<GetUsup_Result> GetUsup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsup_Result>("GetUsup");
        }
    
        public virtual ObjectResult<LoginUser_Result> LoginUser(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginUser_Result>("LoginUser", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetUsup2_Result> GetUsup2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsup2_Result>("GetUsup2");
        }
    
        public virtual ObjectResult<GetBarangSup_Result> GetBarangSup(Nullable<int> id_supplier)
        {
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup_Result>("GetBarangSup", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangSup2_Result> GetBarangSup2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup2_Result>("GetBarangSup2");
        }
    
        public virtual ObjectResult<GetKategori_Result> GetKategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetKategori_Result>("GetKategori");
        }
    
        public virtual int CreateData(Nullable<int> id_kategori, Nullable<int> id_supplier, string kode_barang, string nama_barang, Nullable<int> id_barang, Nullable<int> jumlah_barang, Nullable<System.DateTime> tanggal_masuk, Nullable<int> jum_barang_masuk, Nullable<int> created_by, string deskripsi, Nullable<int> updated_by)
        {
            var id_kategoriParameter = id_kategori.HasValue ?
                new ObjectParameter("id_kategori", id_kategori) :
                new ObjectParameter("id_kategori", typeof(int));
    
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            var kode_barangParameter = kode_barang != null ?
                new ObjectParameter("kode_barang", kode_barang) :
                new ObjectParameter("kode_barang", typeof(string));
    
            var nama_barangParameter = nama_barang != null ?
                new ObjectParameter("nama_barang", nama_barang) :
                new ObjectParameter("nama_barang", typeof(string));
    
            var id_barangParameter = id_barang.HasValue ?
                new ObjectParameter("id_barang", id_barang) :
                new ObjectParameter("id_barang", typeof(int));
    
            var jumlah_barangParameter = jumlah_barang.HasValue ?
                new ObjectParameter("jumlah_barang", jumlah_barang) :
                new ObjectParameter("jumlah_barang", typeof(int));
    
            var tanggal_masukParameter = tanggal_masuk.HasValue ?
                new ObjectParameter("tanggal_masuk", tanggal_masuk) :
                new ObjectParameter("tanggal_masuk", typeof(System.DateTime));
    
            var jum_barang_masukParameter = jum_barang_masuk.HasValue ?
                new ObjectParameter("jum_barang_masuk", jum_barang_masuk) :
                new ObjectParameter("jum_barang_masuk", typeof(int));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            var deskripsiParameter = deskripsi != null ?
                new ObjectParameter("deskripsi", deskripsi) :
                new ObjectParameter("deskripsi", typeof(string));
    
            var updated_byParameter = updated_by.HasValue ?
                new ObjectParameter("updated_by", updated_by) :
                new ObjectParameter("updated_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateData", id_kategoriParameter, id_supplierParameter, kode_barangParameter, nama_barangParameter, id_barangParameter, jumlah_barangParameter, tanggal_masukParameter, jum_barang_masukParameter, created_byParameter, deskripsiParameter, updated_byParameter);
        }
    
        public virtual ObjectResult<GetBarangSup3_Result> GetBarangSup3()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup3_Result>("GetBarangSup3");
        }
    
        public virtual ObjectResult<GetBarangSup4_Result> GetBarangSup4()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangSup4_Result>("GetBarangSup4");
        }
    
        public virtual ObjectResult<GetSupplay_Result> GetSupplay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSupplay_Result>("GetSupplay");
        }
    
        public virtual ObjectResult<GetBarangWhere_Result> GetBarangWhere(Nullable<int> id_supplier)
        {
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhere_Result>("GetBarangWhere", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangWhere2_Result> GetBarangWhere2(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhere2_Result>("GetBarangWhere2", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangWhere3_Result> GetBarangWhere3(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhere3_Result>("GetBarangWhere3", id_supplierParameter);
        }
    
        public virtual ObjectResult<string> GetCreatedSupplier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCreatedSupplier");
        }
    
        public virtual ObjectResult<string> GetCreatedSupplier2(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCreatedSupplier2", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetCreatedSupplier3_Result> GetCreatedSupplier3(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCreatedSupplier3_Result>("GetCreatedSupplier3", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetProfil_Result> GetProfil(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProfil_Result>("GetProfil", id_supplierParameter);
        }
    
        public virtual int CreateDataExist(Nullable<int> id_barang, Nullable<System.DateTime> tanggal_masuk, Nullable<int> jumlah_barang, string deskripsi, Nullable<int> created_by, Nullable<int> id_supplier)
        {
            var id_barangParameter = id_barang.HasValue ?
                new ObjectParameter("id_barang", id_barang) :
                new ObjectParameter("id_barang", typeof(int));
    
            var tanggal_masukParameter = tanggal_masuk.HasValue ?
                new ObjectParameter("tanggal_masuk", tanggal_masuk) :
                new ObjectParameter("tanggal_masuk", typeof(System.DateTime));
    
            var jumlah_barangParameter = jumlah_barang.HasValue ?
                new ObjectParameter("jumlah_barang", jumlah_barang) :
                new ObjectParameter("jumlah_barang", typeof(int));
    
            var deskripsiParameter = deskripsi != null ?
                new ObjectParameter("deskripsi", deskripsi) :
                new ObjectParameter("deskripsi", typeof(string));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            var id_supplierParameter = id_supplier.HasValue ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateDataExist", id_barangParameter, tanggal_masukParameter, jumlah_barangParameter, deskripsiParameter, created_byParameter, id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarang_Result> GetBarang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarang_Result>("GetBarang");
        }
    
        public virtual ObjectResult<GetBarangWhereDist_Result> GetBarangWhereDist(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangWhereDist_Result>("GetBarangWhereDist", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetBarangnya_Result> GetBarangnya(string id_supplier)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBarangnya_Result>("GetBarangnya", id_supplierParameter);
        }
    
        public virtual ObjectResult<GetCreatedSupplier4_Result> GetCreatedSupplier4(string id_supplier, Nullable<int> id_user)
        {
            var id_supplierParameter = id_supplier != null ?
                new ObjectParameter("id_supplier", id_supplier) :
                new ObjectParameter("id_supplier", typeof(string));
    
            var id_userParameter = id_user.HasValue ?
                new ObjectParameter("id_user", id_user) :
                new ObjectParameter("id_user", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCreatedSupplier4_Result>("GetCreatedSupplier4", id_supplierParameter, id_userParameter);
        }
    
        public virtual int spBarangKeluar(Nullable<int> id_brg, Nullable<System.DateTime> tgl, Nullable<int> jml, string desc, Nullable<int> created)
        {
            var id_brgParameter = id_brg.HasValue ?
                new ObjectParameter("id_brg", id_brg) :
                new ObjectParameter("id_brg", typeof(int));
    
            var tglParameter = tgl.HasValue ?
                new ObjectParameter("tgl", tgl) :
                new ObjectParameter("tgl", typeof(System.DateTime));
    
            var jmlParameter = jml.HasValue ?
                new ObjectParameter("jml", jml) :
                new ObjectParameter("jml", typeof(int));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var createdParameter = created.HasValue ?
                new ObjectParameter("created", created) :
                new ObjectParameter("created", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spBarangKeluar", id_brgParameter, tglParameter, jmlParameter, descParameter, createdParameter);
        }
    
        public virtual int spBarangMasukExist(Nullable<int> id_brg, Nullable<System.DateTime> tgl, Nullable<int> jml, string desc, Nullable<int> created)
        {
            var id_brgParameter = id_brg.HasValue ?
                new ObjectParameter("id_brg", id_brg) :
                new ObjectParameter("id_brg", typeof(int));
    
            var tglParameter = tgl.HasValue ?
                new ObjectParameter("tgl", tgl) :
                new ObjectParameter("tgl", typeof(System.DateTime));
    
            var jmlParameter = jml.HasValue ?
                new ObjectParameter("jml", jml) :
                new ObjectParameter("jml", typeof(int));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var createdParameter = created.HasValue ?
                new ObjectParameter("created", created) :
                new ObjectParameter("created", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spBarangMasukExist", id_brgParameter, tglParameter, jmlParameter, descParameter, createdParameter);
        }
    
        public virtual int spBarangMasukNew(Nullable<int> id_brg, Nullable<int> id_sup, Nullable<int> id_kat, string nama_brg, Nullable<System.DateTime> tgl, Nullable<int> jml, string desc, Nullable<int> created, string kode_brg)
        {
            var id_brgParameter = id_brg.HasValue ?
                new ObjectParameter("id_brg", id_brg) :
                new ObjectParameter("id_brg", typeof(int));
    
            var id_supParameter = id_sup.HasValue ?
                new ObjectParameter("id_sup", id_sup) :
                new ObjectParameter("id_sup", typeof(int));
    
            var id_katParameter = id_kat.HasValue ?
                new ObjectParameter("id_kat", id_kat) :
                new ObjectParameter("id_kat", typeof(int));
    
            var nama_brgParameter = nama_brg != null ?
                new ObjectParameter("nama_brg", nama_brg) :
                new ObjectParameter("nama_brg", typeof(string));
    
            var tglParameter = tgl.HasValue ?
                new ObjectParameter("tgl", tgl) :
                new ObjectParameter("tgl", typeof(System.DateTime));
    
            var jmlParameter = jml.HasValue ?
                new ObjectParameter("jml", jml) :
                new ObjectParameter("jml", typeof(int));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var createdParameter = created.HasValue ?
                new ObjectParameter("created", created) :
                new ObjectParameter("created", typeof(int));
    
            var kode_brgParameter = kode_brg != null ?
                new ObjectParameter("kode_brg", kode_brg) :
                new ObjectParameter("kode_brg", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spBarangMasukNew", id_brgParameter, id_supParameter, id_katParameter, nama_brgParameter, tglParameter, jmlParameter, descParameter, createdParameter, kode_brgParameter);
        }
    
        public virtual int spBarangReturn(Nullable<int> id_brg, Nullable<System.DateTime> tgl, Nullable<int> jml, string desc, Nullable<int> created)
        {
            var id_brgParameter = id_brg.HasValue ?
                new ObjectParameter("id_brg", id_brg) :
                new ObjectParameter("id_brg", typeof(int));
    
            var tglParameter = tgl.HasValue ?
                new ObjectParameter("tgl", tgl) :
                new ObjectParameter("tgl", typeof(System.DateTime));
    
            var jmlParameter = jml.HasValue ?
                new ObjectParameter("jml", jml) :
                new ObjectParameter("jml", typeof(int));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var createdParameter = created.HasValue ?
                new ObjectParameter("created", created) :
                new ObjectParameter("created", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spBarangReturn", id_brgParameter, tglParameter, jmlParameter, descParameter, createdParameter);
        }
    
        public virtual int spEditBarang(Nullable<int> id_brg, string nama_brg, string kode_brg, Nullable<int> jml_brg, Nullable<int> kategori, Nullable<int> supplier)
        {
            var id_brgParameter = id_brg.HasValue ?
                new ObjectParameter("id_brg", id_brg) :
                new ObjectParameter("id_brg", typeof(int));
    
            var nama_brgParameter = nama_brg != null ?
                new ObjectParameter("nama_brg", nama_brg) :
                new ObjectParameter("nama_brg", typeof(string));
    
            var kode_brgParameter = kode_brg != null ?
                new ObjectParameter("kode_brg", kode_brg) :
                new ObjectParameter("kode_brg", typeof(string));
    
            var jml_brgParameter = jml_brg.HasValue ?
                new ObjectParameter("jml_brg", jml_brg) :
                new ObjectParameter("jml_brg", typeof(int));
    
            var kategoriParameter = kategori.HasValue ?
                new ObjectParameter("kategori", kategori) :
                new ObjectParameter("kategori", typeof(int));
    
            var supplierParameter = supplier.HasValue ?
                new ObjectParameter("supplier", supplier) :
                new ObjectParameter("supplier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditBarang", id_brgParameter, nama_brgParameter, kode_brgParameter, jml_brgParameter, kategoriParameter, supplierParameter);
        }
    
        public virtual ObjectResult<spGetBarang_Result> spGetBarang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarang_Result>("spGetBarang");
        }
    
        public virtual ObjectResult<spGetBarangJoin_Result> spGetBarangJoin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangJoin_Result>("spGetBarangJoin");
        }
    
        public virtual ObjectResult<spGetBarangJoinID_Result> spGetBarangJoinID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangJoinID_Result>("spGetBarangJoinID");
        }
    
        public virtual ObjectResult<spGetBarangKeluar_Result> spGetBarangKeluar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangKeluar_Result>("spGetBarangKeluar");
        }
    
        public virtual ObjectResult<spGetBarangKeluarJoin_Result> spGetBarangKeluarJoin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangKeluarJoin_Result>("spGetBarangKeluarJoin");
        }
    
        public virtual ObjectResult<spGetBarangList_Result> spGetBarangList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangList_Result>("spGetBarangList");
        }
    
        public virtual ObjectResult<spGetBarangMasuk_Result> spGetBarangMasuk()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangMasuk_Result>("spGetBarangMasuk");
        }
    
        public virtual ObjectResult<spGetBarangMasukJoin_Result> spGetBarangMasukJoin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangMasukJoin_Result>("spGetBarangMasukJoin");
        }
    
        public virtual ObjectResult<spGetBarangReturn_Result> spGetBarangReturn()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangReturn_Result>("spGetBarangReturn");
        }
    
        public virtual ObjectResult<spGetBarangReturnJoin_Result> spGetBarangReturnJoin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangReturnJoin_Result>("spGetBarangReturnJoin");
        }
    
        public virtual ObjectResult<spGetBarangWhere_Result> spGetBarangWhere(Nullable<int> id_brg)
        {
            var id_brgParameter = id_brg.HasValue ?
                new ObjectParameter("id_brg", id_brg) :
                new ObjectParameter("id_brg", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBarangWhere_Result>("spGetBarangWhere", id_brgParameter);
        }
    
        public virtual ObjectResult<spGetKategori_Result> spGetKategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetKategori_Result>("spGetKategori");
        }
    
        public virtual ObjectResult<spGetSupplier_Result> spGetSupplier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetSupplier_Result>("spGetSupplier");
        }
    
        public virtual ObjectResult<spGetSupplierWhere_Result> spGetSupplierWhere(Nullable<int> id_sup)
        {
            var id_supParameter = id_sup.HasValue ?
                new ObjectParameter("id_sup", id_sup) :
                new ObjectParameter("id_sup", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetSupplierWhere_Result>("spGetSupplierWhere", id_supParameter);
        }
    
        public virtual ObjectResult<spGetUser_Result> spGetUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUser_Result>("spGetUser");
        }
    }
}
