using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Chieu3_Buoi4_2011061141_LamChiTinh.Models
{
    public class Giohang
    {
        NhaSachEntities data = new NhaSachEntities();
        public int masach { get; set; }
        [Display(Name = "Tên sách")]
        public string tensach { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name = "Giá bán")]
        public Double giaban { get; set; }
        [Display(Name = "số lượng")]
        public int isoluong { get; set; }
        [Display(Name = "Thành tiền")]
        public Double dThanhtien
        {
            get { return isoluong * giaban; }
        }

        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            isoluong = 1;
        }

    }
    
}
