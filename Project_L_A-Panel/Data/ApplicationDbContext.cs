
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_L_A_Panel.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_L_A_Panel.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser,SomeNames,int>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
