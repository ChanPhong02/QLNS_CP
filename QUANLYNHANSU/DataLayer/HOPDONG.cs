
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DataLayer
{

using System;
    using System.Collections.Generic;
    
public partial class HOPDONG
{

    public int MaHD { get; set; }

    public Nullable<System.DateTime> NgayBD { get; set; }

    public Nullable<System.DateTime> NgayKT { get; set; }

    public Nullable<System.DateTime> NgayKi { get; set; }

    public string NoiDung { get; set; }

    public string ThoiHan { get; set; }

    public Nullable<double> HeSoLuong { get; set; }

    public Nullable<int> MaNV { get; set; }



    public virtual NHANVIEN NHANVIEN { get; set; }

}

}
