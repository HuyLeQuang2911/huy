
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
    using System.Collections.Generic;
    
public partial class PHIEUNHAP
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PHIEUNHAP()
    {

        this.CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();

    }


    public string IDPHIEUNHAP { get; set; }

    public string MANV { get; set; }

    public string MANCC { get; set; }

    public Nullable<System.DateTime> NGAYNHAP { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }

    public virtual NHACC NHACC { get; set; }

    public virtual NHANVIEN NHANVIEN { get; set; }

}

}