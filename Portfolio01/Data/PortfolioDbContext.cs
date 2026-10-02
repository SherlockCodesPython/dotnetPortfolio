using Microsoft.EntityFrameworkCore;
using Portfolio01.Models.HomePage;

namespace Portfolio01.Data
{
    public class PortfolioDbContext : DbContext
    {
        //dbconstructors
        public PortfolioDbContext(DbContextOptions PortfolioDbContextOptions) : base(PortfolioDbContextOptions)
        // dboptions to set the db connection string and other options from prg.cs // portfolioDbContext is the name of the dbcontext class

        {


        }

        //dbsets as collention for entities

        public DbSet<Personalinfo> Personalinfos { get; set; }

        public DbSet<ProfessionalExperience> ProfessionalExperiences { get; set; }

        public DbSet<SkillSet> Skills { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Certifications> Certificates { get; set; }



    }
}
