using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Tural-Hasanov\\SQLExpress123; database=Project_L; integrated security=true;");
            //optionsBuilder.UseSqlServer("Data Source=SQL5110.site4now.net;Initial Catalog=db_a9d199_projectl;User Id=db_a9d199_projectl_admin;Password=tural123");


            //optionsBuilder.UseSqlServer("workstation id=Project_L.mssql.somee.com;packet size=4096;user id=scorp_SQLLogin_1;pwd=l6bjmjxoxd;data source=Project_L.mssql.somee.com;persist security info=False;initial catalog=Project_L;");


        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<HrTeam> HrTeams { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PartnerCompany> PartnerCompanies { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<MessageFromExternal> MessageFromExternals { get; set; }
        public DbSet<GalleryMainSite> GalleryMainSites { get; set; }
        public DbSet<AzfenEmployee> AzfenEmployees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperiences { get; set; }
        public DbSet<EmployeePhoto> EmployeePhotos { get; set; }


    }
}
