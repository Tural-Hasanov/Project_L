﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogCategory
    {
        [Key]
        public int BlogCategoryID { get; set; }
        public string BlogCategoryName { get; set; }
        public string BlogCategoryDescription { get; set; }
        public bool BlogCategoryStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
