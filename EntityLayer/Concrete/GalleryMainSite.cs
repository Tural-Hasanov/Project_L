using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GalleryMainSite
    {
        [Key]
        public int GalleryImageID { get; set; }
        public string GalleryImageName { get; set; }
        public string GalleryImageUrl { get; set; }
        public string GalleryImageFilter { get; set; }
        public bool GalleryImageStatus { get; set; }
    }
}
