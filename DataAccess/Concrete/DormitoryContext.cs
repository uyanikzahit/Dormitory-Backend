
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DormitoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-S7FTT1D;Database=Dormitory;Trusted_Connection=true;TrustServerCertificate=True");
        }


        public DbSet<OperationClaim> OperationClaims { get; set; }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<Cafeteria> Cafeterias { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Suggestion> Suggestions { get; set; }

        public DbSet<UserImage> UserImages { get; set; },
        public DbSet<Work> Works { get; set; }




    }
}
