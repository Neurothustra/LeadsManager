using Microsoft.EntityFrameworkCore;
using LeadsManager.Models;

namespace LeadsManager.Data
{
    public class LeadsContext : DbContext
    {
        public LeadsContext (DbContextOptions<LeadsContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Application { get; set; }
        public DbSet<EmailUs> EmailUs { get; set; }
        public DbSet<Inquiry> Inquiry { get; set; }
        public DbSet<LandingPage> LandingPage { get; set; }
        public DbSet<OpenHouse> OpenHouse { get; set; }
        public DbSet<QuestionForUs> QuestionForUs { get; set; }
        public DbSet<ReferAFriend> ReferAFriend { get; set; }
    }
}
