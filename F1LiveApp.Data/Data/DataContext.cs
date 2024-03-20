using F1LiveApp.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1LiveApp.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Session> Sessions { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Session>()
				.HasOne(s => s.Meeting)
				.WithMany()
				.HasForeignKey(s => s.Meeting_Key);

			modelBuilder.Entity<Driver>()
				.HasOne(d => d.Session)
				.WithMany()
				.HasForeignKey(d => d.Session_Key);

			modelBuilder.Entity<Driver>()
				.HasOne(d => d.Meeting)
				.WithMany()
				.HasForeignKey(d => d.Meeting_Key);
		}
	}
}
