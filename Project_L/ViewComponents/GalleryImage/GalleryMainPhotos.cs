using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.ViewComponents.GalleryImage
{
    public class GalleryMainPhotos : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Images image = new Images();

            return View(image.GalleryMainSites());
        }
    }
    public class Images
    {
        public List<GalleryMainSite> GalleryMainSites()
        {
            using var c = new Context();
            var list = c.GalleryMainSites.ToList();
            return list;
        }
    }
}
