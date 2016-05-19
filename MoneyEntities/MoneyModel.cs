namespace MoneyEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// Class that maps the database with the classes (Currency and MoneyChange)
    /// </summary>
    /// <Important>The database is on the MoneyDB.mdf file</Important>
    public partial class MoneyModel : DbContext
    {
        public MoneyModel()
            : base("name=MoneyModel")
        {
        }

        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<MoneyChange> MoneyChange { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
