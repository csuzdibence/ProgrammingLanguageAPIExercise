namespace ProgrammingLanguage.Data
{
    using Microsoft.EntityFrameworkCore;

    public class ProgrammingLanguageDbContext : DbContext
    {
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public ProgrammingLanguageDbContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgrammingLanguage>().HasData(
                new ProgrammingLanguage { Id = 1, Name = "JavaScript", TypeSystem = "Dynamic", FirstAppeared = 1995, Platform = "Web", UsagePercentage = 67.8 },
                new ProgrammingLanguage { Id = 2, Name = "C#", TypeSystem = "Static", FirstAppeared = 2000, Platform = ".NET", UsagePercentage = 31.4 },
                new ProgrammingLanguage { Id = 3, Name = "Java", TypeSystem = "Static", FirstAppeared = 1995, Platform = "Enterprise", UsagePercentage = 34.2 },
                new ProgrammingLanguage { Id = 4, Name = "Python", TypeSystem = "Dynamic", FirstAppeared = 1991, Platform = "Data Science", UsagePercentage = 48.2 },
                new ProgrammingLanguage { Id = 5, Name = "Go", TypeSystem = "Static", FirstAppeared = 2009, Platform = "Backend", UsagePercentage = 12.7 },
                new ProgrammingLanguage { Id = 6, Name = "Rust", TypeSystem = "Static", FirstAppeared = 2010, Platform = "System Programming", UsagePercentage = 9.5 },
                new ProgrammingLanguage { Id = 7, Name = "Kotlin", TypeSystem = "Static", FirstAppeared = 2011, Platform = "Mobile", UsagePercentage = 7.3 },
                new ProgrammingLanguage { Id = 8, Name = "Swift", TypeSystem = "Static", FirstAppeared = 2014, Platform = "iOS", UsagePercentage = 5.8 },
                new ProgrammingLanguage { Id = 9, Name = "PHP", TypeSystem = "Dynamic", FirstAppeared = 1995, Platform = "Web", UsagePercentage = 20.1 },
                new ProgrammingLanguage { Id = 10, Name = "R", TypeSystem = "Dynamic", FirstAppeared = 1993, Platform = "Data Science", UsagePercentage = 6.9 }
            );
        }
    }

}
