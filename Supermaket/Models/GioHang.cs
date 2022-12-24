using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supermaket.DB;

namespace Supermaket.Models
{
    public class GioHang
    {
        BTL_WEBEntities db = new BTL_WEBEntities();
        public string sMaHang { get; set; }

        public string sTenHang { get; set; }

        public string sAnh { get; set; }

        public double dGiaBan { get; set; }
        public int iSoLuong { get; set; }

        public double dThanhTien
        {
            get { return iSoLuong * dGiaBan; }
        }

        public GioHang(string MaHang)
        {
            sMaHang = MaHang;
            HANGHOA hanghoa = db.HANGHOAs.SingleOrDefault
                (n => n.MAHANG == sMaHang);
            sTenHang = hanghoa.TENHANG;
            sAnh = hanghoa.ANH;
            dGiaBan = double.Parse(hanghoa.GIABAN.ToString());
            iSoLuong = 1;
        }
    }
}