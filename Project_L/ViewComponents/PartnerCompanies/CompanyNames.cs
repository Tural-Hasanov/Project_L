using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.ViewComponents.PartnerCompanies
{
    public class CompanyNames : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var getlist = c.Set<PartnerCompany>().ToList();
            ViewBag.bp = getlist.Where(x => x.CompanyID == 1).Select(y => y.CompanyName).FirstOrDefault();
            ViewBag.tekfen = getlist.Where(x => x.CompanyID == 2).Select(y => y.CompanyName).FirstOrDefault();
            ViewBag.bakerhuges = getlist.Where(x => x.CompanyID == 3).Select(y => y.CompanyName).FirstOrDefault();
            ViewBag.woodgroup = getlist.Where(x => x.CompanyID == 4).Select(y => y.CompanyName).FirstOrDefault();
            ViewBag.bpd = getlist.Where(x => x.CompanyID == 1).Select(y => y.CompanyDescription).FirstOrDefault();
            ViewBag.tekfend = getlist.Where(x => x.CompanyID == 2).Select(y => y.CompanyDescription).FirstOrDefault();
            ViewBag.bakerhugesd = getlist.Where(x => x.CompanyID == 3).Select(y => y.CompanyDescription).FirstOrDefault();
            ViewBag.woodgroupd = getlist.Where(x => x.CompanyID == 4).Select(y => y.CompanyDescription).FirstOrDefault();
            return View(getlist);
        }
    }
}
