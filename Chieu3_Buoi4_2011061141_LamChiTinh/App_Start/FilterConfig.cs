using System.Web;
using System.Web.Mvc;

namespace Chieu3_Buoi4_2011061141_LamChiTinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
