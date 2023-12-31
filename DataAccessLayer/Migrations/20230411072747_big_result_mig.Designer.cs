﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230411072747_big_result_mig")]
    partial class big_result_mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutEmailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutFacebookAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutInstagramAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutLinkedinAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.Property<string>("AboutTwitterAdress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AzfenEmployee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Badge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitizenShip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectIndirect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmploymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FathersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LSRE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OccupationalChange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelClassification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PmtSplit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonOfResignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResignationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SAA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialistDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("AzfenEmployees");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("BlogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HrTeamID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("BlogCategoryID");

                    b.HasIndex("HrTeamID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogCategory", b =>
                {
                    b.Property<int>("BlogCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogCategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogCategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("BlogCategoryID");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogComment", b =>
                {
                    b.Property<int>("BlogCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BlogCommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogCommentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("HrTeamID")
                        .HasColumnType("int");

                    b.HasKey("BlogCommentID");

                    b.HasIndex("BlogID");

                    b.HasIndex("HrTeamID");

                    b.ToTable("BlogComments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeDepartment", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("EmployeeDepartments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AllVacationDay")
                        .HasColumnType("int");

                    b.Property<string>("Badge")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("BalanceVacation")
                        .HasColumnType("int");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeDepartmentDepartmentID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeePhotoID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EmploymentStartDate")
                        .IsRequired()
                        .HasColumnType("Date");

                    b.Property<int>("ExpDay")
                        .HasColumnType("int");

                    b.Property<int>("ExpMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpYear")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceVacationDay")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentitySerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RangeDay")
                        .HasColumnType("int");

                    b.Property<int>("RangeMonth")
                        .HasColumnType("int");

                    b.Property<int>("RangeYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResignationDate")
                        .HasColumnType("Date");

                    b.Property<double?>("Salary")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("TabelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsedVacationDay")
                        .HasColumnType("int");

                    b.Property<int?>("UsedVacationPeriod")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<int?>("VacationDay")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeDepartmentDepartmentID");

                    b.HasIndex("EmployeePhotoID");

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeDocument", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EmployeeDocuments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeDetailID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EmploymentStartDate")
                        .HasColumnType("Date");

                    b.Property<int>("RangeDay")
                        .HasColumnType("int");

                    b.Property<int>("RangeMonth")
                        .HasColumnType("int");

                    b.Property<int>("RangeYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResignationDate")
                        .HasColumnType("Date");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeDetailID");

                    b.ToTable("EmployeeExperiences");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeePhoto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EmployeePhotos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.GalleryMainSite", b =>
                {
                    b.Property<int>("GalleryImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GalleryImageFilter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GalleryImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GalleryImageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("GalleryImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GalleryImageID");

                    b.ToTable("GalleryMainSites");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HrTeam", b =>
                {
                    b.Property<int>("HrTeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutFacebookAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutInstagramAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutLinkedinAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTwitterAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrTeamImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrTeamOpinion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrTeamPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrTeamSAA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HrTeamID");

                    b.ToTable("HrTeams");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MessageFromExternal", b =>
                {
                    b.Property<int>("MessageFromExternalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageFromExternalContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageFromExternalEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageFromExternalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageFromExternalSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageFromExternalID");

                    b.ToTable("MessageFromExternals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PartnerCompany", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CompanyStatus")
                        .HasColumnType("bit");

                    b.HasKey("CompanyID");

                    b.ToTable("PartnerCompanies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.BlogCategory", "BlogCategory")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.HrTeam", "HrTeam")
                        .WithMany("Blogs")
                        .HasForeignKey("HrTeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogCategory");

                    b.Navigation("HrTeam");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogComment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("BlogComments")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.HrTeam", "HrTeam")
                        .WithMany("BlogComments")
                        .HasForeignKey("HrTeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("HrTeam");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeDetail", b =>
                {
                    b.HasOne("EntityLayer.Concrete.EmployeeDepartment", "EmployeeDepartment")
                        .WithMany("EmployeeDetails")
                        .HasForeignKey("EmployeeDepartmentDepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.EmployeePhoto", "EmployeePhoto")
                        .WithMany("EmployeeDetails")
                        .HasForeignKey("EmployeePhotoID");

                    b.Navigation("EmployeeDepartment");

                    b.Navigation("EmployeePhoto");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeExperience", b =>
                {
                    b.HasOne("EntityLayer.Concrete.EmployeeDetail", "EmployeeDetail")
                        .WithMany("EmployeeExperiences")
                        .HasForeignKey("EmployeeDetailID");

                    b.Navigation("EmployeeDetail");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("BlogComments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogCategory", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeDepartment", b =>
                {
                    b.Navigation("EmployeeDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeeDetail", b =>
                {
                    b.Navigation("EmployeeExperiences");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EmployeePhoto", b =>
                {
                    b.Navigation("EmployeeDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HrTeam", b =>
                {
                    b.Navigation("BlogComments");

                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
