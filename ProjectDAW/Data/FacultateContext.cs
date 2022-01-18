using Microsoft.EntityFrameworkCore;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Data
{
    public class FacultateContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Facultate> Facultate { get; set; }
        public DbSet<Adresa> Adresa { get; set; }

        public FacultateContext(DbContextOptions<FacultateContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(x => x.Facultate)
                .WithMany(y => y.Useri)
                .HasForeignKey(z => z.FacultateId);

            builder.Entity<Adresa>()
            .HasOne(x => x.Facultate)
            .WithOne(y => y.Adresa)
            .HasForeignKey <Facultate>(z => z.FacultateId);

            builder.Entity<UserRole>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.UserId);

            builder.Entity<UserRole>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.RoleId);

            builder.Entity<UserRole>()
                .HasAlternateKey(x => new { x.UserId, x.RoleId });
        }
    }
}
