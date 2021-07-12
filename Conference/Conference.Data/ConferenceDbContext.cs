using Conference.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Conference.Data
{
    public class ConferenceDbContext : DbContext
    {
        public ConferenceDbContext(DbContextOptions<ConferenceDbContext> options) : base(options)
        {

        }

        public DbSet<Conferences> Conferences { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Attendee> Attendees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conferences>().HasData(new Conferences { Id = 1, Name = "Pluralsight Live", Location = "Salt Lake City", Start = new DateTime(2019, 10, 12) });
            modelBuilder.Entity<Conferences>().HasData(new Conferences { Id = 2, Name = "Pluralsight Live", Location = "London", Start = new DateTime(2019, 3, 18) });

            modelBuilder.Entity<Proposal>().HasData(new Proposal
            {
                Id = 1,
                ConferenceId = 1,
                Speaker = "Roland Guijt",
                Title = "Authentication and Authorization in ASP.NET Core"
            });

            modelBuilder.Entity<Proposal>().HasData(new Proposal
            {
                Id = 2,
                ConferenceId = 2,
                Speaker = "Cindy Reynolds",
                Title = "Starting Your Developer Career"
            });
            modelBuilder.Entity<Proposal>().HasData(new Proposal
            {
                Id = 3,
                ConferenceId = 2,
                Speaker = "Heather Lipens",
                Title = "ASP.NET Core TagHelpers"
            });

            modelBuilder.Entity<Attendee>().HasData(new Attendee { Id = 1, ConferenceId = 1, Name = "Lisa Overthere" });
            modelBuilder.Entity<Attendee>().HasData(new Attendee { Id = 2, ConferenceId = 1, Name = "Robin Eisenberg" });
            modelBuilder.Entity<Attendee>().HasData(new Attendee { Id = 3, ConferenceId = 2, Name = "Sue Mashmellow" });
        }
    }
}