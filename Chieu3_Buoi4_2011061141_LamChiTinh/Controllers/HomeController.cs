using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Chieu3_Buoi4_2011061141_LamChiTinh.Models;
using PagedList;
namespace Chieu3_Buoi4_2011061141_LamChiTinh.Controllers
{
    public class HomeController : Controller
    {
        NhaSachEntities data = new NhaSachEntities();
        public ActionResult Index(int ? page)
        {
            if (page == null) page = 1;
            var all_Sach = (from ss in data. Saches select ss).OrderBy(m => m.masach);
            var all_sach = (from s in data.Saches select s).OrderBy(m => m.masach);
            int pageSize = 3;
            int pageNum = page ?? 1;
            return View(all_sach.ToPagedList(pageNum, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}