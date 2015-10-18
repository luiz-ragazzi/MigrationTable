namespace MigrationTable
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IntranetDataContext : DbContext
    {
        public IntranetDataContext(string name)
            : base(name)
        {
        }

        public virtual DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .Property(e => e.datatype)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.fulltexttime)
                .IsFixedLength();
        }
    }
}
