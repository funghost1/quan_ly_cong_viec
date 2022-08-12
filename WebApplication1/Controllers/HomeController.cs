using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CVDuocgiao(string strSearch)
        {
            int a = 06543210;
            thuctap db = new thuctap();
            var laycvdg = (from item in db.CONGVIECs
                           where item.ID_NGUOI_NHAN == a
                           select item
                           ).ToList();
            if (!String.IsNullOrEmpty(strSearch))
            {
                laycvdg = laycvdg.Where(x => x.TIEU_DE.Contains(strSearch) || x.TRANGTHAICONGVIEC.TEN_TRANG_THAI.Contains(strSearch) ||x.DOQUANTRONG.TEN_DO_QUAN_TRONG.Contains(strSearch)).ToList();
            }
            ViewBag.strSearch = strSearch;
            return View(laycvdg);
        }

        public ActionResult CVHoangThanh(string strSearch)
        {
            int a = 06543210;
            thuctap db = new thuctap();
            var laycvdg = (from item in db.CONGVIECs
                           where item.ID_NGUOI_NHAN == a && item.ID_TRANG_THAI == 1
                           select item
                           ).ToList();
            return View(laycvdg);
        }

        public ActionResult CVChuaHoangThanh(string strSearch)
        {
            int a = 06543210;
            thuctap db = new thuctap();
            var laycvdg = (from item in db.CONGVIECs
                           where item.ID_NGUOI_NHAN == a && item.ID_TRANG_THAI == 2
                           select item
                           ).ToList();
            return View(laycvdg);
        }

        public ActionResult Details(int id)
        {
            var context = new thuctap();
            var detail = context.CONGVIECs.Find(id);
            return View(detail);
        }

        public ActionResult EditCVDuocgiao(int id)
        {
            var context = new thuctap();
            var editcvduocgiao = context.CONGVIECs.Find(id);
            return View(editcvduocgiao);
        }
        [HttpPost]
        public ActionResult EditCVDuocgiao(CONGVIEC model)
        {
            thuctap db = new thuctap();
            var tim = db.CONGVIECs.Find(model.ID_CONG_VIEC);
            if(model.TY_LE_HOAN_THANH > 100)
            {
                ModelState.AddModelError("", "Tỷ lệ hoàn thành khộng được vượt quá 100% ");
                return View(model);
            }
            tim.TY_LE_HOAN_THANH = model.TY_LE_HOAN_THANH;
            int tilehoanthanh = model.TY_LE_HOAN_THANH;
            if(tilehoanthanh >= 100)
            {
                tim.ID_TRANG_THAI = 1;
                db.SaveChanges();
            }
            else
            {
                tim.ID_TRANG_THAI = 2;
                db.SaveChanges();
            }
            db.SaveChanges();
            return RedirectToAction("CVDuocgiao");
        }

        public ActionResult CVDagiao(string strSearch)
        {
            int a = 06543210;
            thuctap db = new thuctap();
            var laycvdg = (from item in db.CONGVIECs
                           where item.ID_NGUOI_GUI == a
                           select item
                           ).ToList();
            return View(laycvdg);
        }

        public ActionResult Index()
        {
            DateTime ngay = Convert.ToDateTime(DateTime.Now);
            DateTime ngayhientai = DateTime.Today.AddDays(+7);
            int a = 06543210;
            thuctap db = new thuctap();
            var laycvdg = (from item in db.CONGVIECs
                           where item.ID_NGUOI_NHAN == a
                           select item
                           ).ToList();

            var nhatviec = (from item in db.CONGVIECs
                      where item.NGAY_HET_HAN < ngayhientai && item.NGAY_HET_HAN > ngay && item.ID_NGUOI_NHAN == a && item.ID_TRANG_THAI == 2
                      select item
                      ).ToList();

            var laycvdagiao = (from item in db.CONGVIECs
                           where item.ID_NGUOI_GUI == a 
                           select item
                           ).ToList();

            var laycvdghoangthanh = (from item in db.CONGVIECs
                           where item.ID_NGUOI_NHAN == a && item.ID_TRANG_THAI == 1
                           select item
                           ).ToList();
            var laycvdgchuahoangthanh = (from item in db.CONGVIECs
                                     where item.ID_NGUOI_NHAN == a && item.ID_TRANG_THAI == 2 || item.ID_TRANG_THAI == 3
                                         select item
                           ).ToList();
            var laycvchuahoangthanh = new SelectList(laycvdg, "ID_NGUOI_NHAN");
            var laycvhoangthanh = new SelectList(laycvdg, "ID_NGUOI_NHAN");
            var laynguoinhan = new SelectList(laycvdagiao, "ID_NGUOI_GUI");
            var laynguoigui = new SelectList(laycvdg, "ID_NGUOI_NHAN");
            var laynhatviec = new SelectList(nhatviec, "ID_NGUOI_NHAN");
            ViewBag.CountNhatViec = laynhatviec.Count();
            ViewBag.CountCHT = laycvdgchuahoangthanh.Count();
            ViewBag.CountHT = laycvdghoangthanh.Count();
            ViewBag.Count1 = laycvdagiao.Count();
            ViewBag.Count = laycvdg.Count();
            return View();
        }

        public ActionResult Create()
        {
            var context = new thuctap();
            var laydoquantrong = new SelectList(context.DOQUANTRONGs, "ID_DO_QUAN_TRONG", "TEN_DO_QUAN_TRONG");
            var laynhanvien = new SelectList(context.NHANVIENs, "ID_NHAN_VIEN", "HO_TEN");
            var laytaptin = new SelectList(context.FILEDINHKEMs, "ID_TAP_TIN", "TEN_TAP_TIN");
            var laylinhvuc = new SelectList(context.LINHVUCs, "ID_LINH_VUC", "TEN_LINH_VUC");
            var laytrangthai = new SelectList(context.TRANGTHAICONGVIECs, "ID_TRANG_THAI", "TEN_TRANG_THAI");
            var laymanhanviengui = new SelectList(context.NHANVIENs, "MA_NHAN_VIEN", "MA_NHAN_VIEN");
            var laymanhanviennhan = new SelectList(context.NHANVIENs, "MA_NHAN_VIEN", "MA_NHAN_VIEN");
            ViewBag.ID_DO_QUAN_TRONG = laydoquantrong;
            ViewBag.ID_NHAN_VIEN = laynhanvien;
            ViewBag.ID_TAP_TIN = laytaptin;
            ViewBag.ID_LINH_VUC = laylinhvuc;
            ViewBag.ID_TRANG_THAI = laytrangthai;
            ViewBag.ID_NGUOI_GUI = laymanhanviengui;
            ViewBag.ID_NGUOI_NHAN = laymanhanviennhan;
            return View();
        }

        [HttpPost]
        public ActionResult Create(CONGVIEC model)
        {
            try
            {
                var context = new thuctap();
                context.CONGVIECs.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult nhatviec(string strSearch)
        {
            DateTime ngay = Convert.ToDateTime(DateTime.Now);
            DateTime ngayhientai = DateTime.Today.AddDays(+7);
            int a = 06543210;
            thuctap db = new thuctap();
            var cv = (from item in db.CONGVIECs
                      where item.NGAY_HET_HAN < ngayhientai && item.NGAY_HET_HAN > ngay && item.ID_NGUOI_NHAN == a && item.ID_TRANG_THAI == 2
                      select item
                      ).ToList();
            return View(cv);
        }
    }
}