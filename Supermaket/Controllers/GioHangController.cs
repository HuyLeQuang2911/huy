using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermaket.Models;
using Supermaket.DB;

namespace Supermaket.Controllers
{
    public class GioHangController : Controller
    {
        BTL_WEBEntities db = new BTL_WEBEntities();
        // GET: GioHang
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as
                List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }

        public List<GioHang> Lay1SP()
        {
            List<GioHang> lstGioHang = Session["Lay1SP"] as
                List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["Lay1SP"] = lstGioHang;
            }
            return lstGioHang;
        }

        public ActionResult ThemGioHang(string sMasp, string strUrl)
        {
            if (db.HANGHOAs.SingleOrDefault(n => n.MAHANG == sMasp) == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lay ra session gio hang
            List<GioHang> lstGiohang = LayGioHang();
            //kiểm tra sản phẩm chọn có trong giỏ hàng chưa
            GioHang spgh = lstGiohang.Find(n => n.sMaHang == sMasp);
            if (spgh == null)
            {
                spgh = new GioHang(sMasp);
                lstGiohang.Add(spgh);
                return Redirect(strUrl);
            }
            else
            {
                spgh.iSoLuong++;
                return Redirect(strUrl);
            }
        }
        //tao view gio hang
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                RedirectToAction("Index", "PageUser");
            }
            List<GioHang> lstGioHang = LayGioHang();
            return View(lstGioHang);
        }
        public ActionResult MuaSP()
        {
            if (Session["Lay1SP"] == null)
            {
                RedirectToAction("Index", "PageUser");
            }
            List<GioHang> lstGioHang = Lay1SP();
            return View(lstGioHang);
        }
        private int TongSoLuong()
        {
            int TongSL = 0;
            List<GioHang> lstGioHang = LayGioHang();
            if (lstGioHang != null)
            {
                TongSL = lstGioHang.Sum(n => n.iSoLuong);
            }
            return TongSL;
        }


        public ActionResult partialGioHang()
        {
            if (TongSoLuong() != 0)
            {
                ViewBag.TongSL = TongSoLuong();
            }
            return PartialView();
        }
        public ActionResult SuaGioHang()
        {
            if (Session["GioHang"] == null)
            {
                RedirectToAction("Index", "PageUser");
            }
            List<GioHang> lstGioHang = LayGioHang();
            return View(lstGioHang);

        }
        public ActionResult CapNhatGiohang(string sMaSp, FormCollection f)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sp = lstGioHang.SingleOrDefault(n => n.sMaHang == sMaSp);
            if (sp != null)
            {
                sp.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("SuaGioHang");
        }
        public ActionResult XoaGioHang(string sMasp)
        {
            
            List<GioHang> lstGiohang = LayGioHang();
            //kiểm tra sản phẩm chọn có trong giỏ hàng chưa
            GioHang spgh = lstGiohang.Find(n => n.sMaHang == sMasp);
            lstGiohang.Remove(spgh);
            return RedirectToAction("SuaGioHang");
        }

        public ActionResult ThanhToan1SP(string sMasp)
        {
            List<GioHang> lstGioHang = Lay1SP();
            GioHang spgh = new GioHang(sMasp);
            lstGioHang.Add(spgh);
            return RedirectToAction("MuaSP");
        }
        /*public ActionResult DatHang()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "NguoiDung");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "SanPham");
            }
            tHoaDonBan ddh = new tHoaDonBan();
            tKhachHang kh = (tKhachHang)Session["TaiKhoan"];
            ddh.MaKH = kh.MaKH;
            ddh.NgayBan = DateTime.Now;
            db.tHoaDonBans.Add(ddh);
            db.SaveChanges();
            List<GioHang> lstGioHang = LayGioHang();
            foreach (var item in lstGioHang)
            {
                tChiTietHDB cthd = new tChiTietHDB();
                cthd.SoHDB = ddh.SoHDB;
                cthd.MaSP = item.sMaSP;
                cthd.SoLuong = item.iSoLuong;
                cthd.DonGia = item.dDonGia;

                db.tChiTietHDBs.Add(cthd);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "SanPham");
        }*/

    }
}