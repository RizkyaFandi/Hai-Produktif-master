namespace LoginCobaCoba
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=AkunModel")
        {
        }

        public virtual DbSet<Akun> Akun { get; set; }
        public virtual DbSet<Loker> Loker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
