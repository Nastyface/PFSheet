using PFSheet.DAL.DTO;
using System.Data.Entity;

namespace PFSheet.DAL.MSSQL.Contexts
{
    internal class DefaultContext : DbContext
    {
        public DefaultContext(string connectionString)
            : base(connectionString)
        {
        }

        //private List<AbilityScore> AbilityScores;
        //private List<Size> Sizes;
        //private List<ILanguage> Languages;
        //private List<Skill> Skills;
        //private List<ILanguage> Races;
        //private List<PFClass> Classes;

        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<PFClass> Class { get; set; }
        //public DbSet<PFClassLevelStats> PFClassLevelStats { get; set; }
        public DbSet<Race> Race { get; set; }
        //public DbSet<RaceSkillBonus> RaceSkillBonuses { get; set; }
        //public DbSet<RaceAbilityScoreBonus> RaceStatBonuses { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
        
        
    }
}
