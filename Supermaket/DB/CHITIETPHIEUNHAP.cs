
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
    
public partial class CHITIETPHIEUNHAP
{

    public string IDPHIEUNHAP { get; set; }

    public string MAHANG { get; set; }

    public Nullable<int> SOLUONG { get; set; }

    public Nullable<double> THANHTIEN { get; set; }



    public virtual PHIEUNHAP PHIEUNHAP { get; set; }

    public virtual HANGHOA HANGHOA { get; set; }

}

}
