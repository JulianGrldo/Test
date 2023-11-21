using Microsoft.EntityFrameworkCore;
using Conferex.Shared.Entities;


namespace Conferex.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleConference> ScheduleConferences { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Topic> Topics { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Assistant>().HasIndex(c => c.DocumentAsis).IsUnique();
            modelBuilder.Entity<Attendance>().HasIndex(c => c.NumberConf).IsUnique();
            modelBuilder.Entity<Organizer>().HasIndex(c => c.NameOrga).IsUnique();
            modelBuilder.Entity<Schedule>().HasIndex(c => c.ScheduleIni).IsUnique();
            modelBuilder.Entity<Sponsor>().HasIndex(c => c.NamePatro).IsUnique();
            modelBuilder.Entity<Topic>().HasIndex(c => c.SpeakerConfer).IsUnique();

        }

    }
}
