//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessAcessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHDBan
    {
        public string MaHDB { get; set; }
        public string MaSach { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual HoaDonBan HoaDonBan { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
