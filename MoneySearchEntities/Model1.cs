namespace MoneySearchEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Money> Money { get; set; }
        public virtual DbSet<MoneySearches> MoneySearches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Money>()
                .Property(e => e.moneyValue)
                .HasPrecision(18, 0);
        }
    }
}
