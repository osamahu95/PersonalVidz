using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Identity;
using Model.Model;
using Model.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PersonalVidzDbContext: IdentityDbContext<User, ApplicationRole, Guid>
    {
        public PersonalVidzDbContext(DbContextOptions<PersonalVidzDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<UserVideo> UserVideos { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<VideoCategory> VideoCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity => { 
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Permission>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Category>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Video>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<UserPermission>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UserId).IsRequired();
                entity.Property(e => e.PermissionId).IsRequired();
            });

            modelBuilder.Entity<VideoCategory>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.VideoId).IsRequired();
                entity.Property(e => e.CategoryId).IsRequired();
            });

            modelBuilder.Entity<UserVideo>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UserId).IsRequired();
                entity.Property(e => e.VideoId).IsRequired();
            });
        }
    }
}
