using Microsoft.EntityFrameworkCore;

namespace CalorieCalculator.Api.Models
{
    public partial class CalCalcContext : DbContext
    {
        public CalCalcContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<CalEntry>(e => e.ToTable("CalEntries"));
            bldr.Entity<DextroseConcentration>(e => e.ToTable("DextroseConcentrations"));
            bldr.Entity<FluidInfusion>(e => e.ToTable("FluidInfusions"));
            bldr.Entity<Site>(e => e.ToTable("Sites"));
            bldr.Entity<Subject>(e => e.ToTable("Subjects"));
        }


        public virtual DbSet<CalEntry> CalEntries { get; set; }
        public virtual DbSet<DextroseConcentration> DextroseConcentrations { get; set; }
        public virtual DbSet<FluidInfusion> FluidInfusions { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }
}