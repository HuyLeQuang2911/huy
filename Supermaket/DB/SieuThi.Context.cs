﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Supermaket.DB
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class BTL_WEBEntities : DbContext
{
    public BTL_WEBEntities()
        : base("name=BTL_WEBEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<ANHHH> ANHHHs { get; set; }

    public virtual DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }

    public virtual DbSet<CHITIETPHIEUXUAT> CHITIETPHIEUXUATs { get; set; }

    public virtual DbSet<CHUCVU> CHUCVUs { get; set; }

    public virtual DbSet<HANGHOA> HANGHOAs { get; set; }

    public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }

    public virtual DbSet<NHACC> NHACCs { get; set; }

    public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

    public virtual DbSet<NHASANXUAT> NHASANXUATs { get; set; }

    public virtual DbSet<NHOMHANG> NHOMHANGs { get; set; }

    public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }

    public virtual DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

}

}

