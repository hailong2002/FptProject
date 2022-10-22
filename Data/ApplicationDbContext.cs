using FPTBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Request> requests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            SeedUser(builder);

            SeedRole(builder);

            SeedUserRole(builder);
        }


        private void SeedUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                EmailConfirmed = true,

            };

            var bookOwner = new IdentityUser
            {
                Id = "2",
                UserName = "bookowner@gmail.com",
                Email = "bookowner@gmail.com",
                NormalizedUserName = "bookowner@gmail.com",
                EmailConfirmed = true,
            };

            var customer = new IdentityUser
            {
                Id = "3",
                UserName = "customer@gmail.com",
                Email = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com",
                EmailConfirmed = true,
            };



            var hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            bookOwner.PasswordHash = hasher.HashPassword(bookOwner, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");

            builder.Entity<IdentityUser>().HasData(admin,  bookOwner, customer);
        }

        private void SeedRole(ModelBuilder builder)
        {
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator",
            };

            var bookOwner = new IdentityRole
            {
                Id = "B",
                Name = "BookOwner",
                NormalizedName = "BookOwner",
            };

            var customer = new IdentityRole
            {
                Id = "C",
                Name = "Customer",
                NormalizedName = "Customer"
            };
            builder.Entity<IdentityRole>().HasData(admin, bookOwner, customer);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
              new IdentityUserRole<string>
              {
                  UserId = "1",
                  RoleId = "A"
              },

              new IdentityUserRole<string>
              {
                  UserId = "2",
                  RoleId = "B"
              },

              new IdentityUserRole<string>
              {
                  UserId = "3",
                  RoleId = "C"
              }

                );
        }

    
    }
}
