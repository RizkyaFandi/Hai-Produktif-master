namespace LoginCobaCoba
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AkunModel : DbContext
    {
        public AkunModel()
            : base("name=AkunModel")
        {
        }

        public virtual DbSet<Akun> Akun { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
