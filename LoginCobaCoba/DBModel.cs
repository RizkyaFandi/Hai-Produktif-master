namespace LoginCobaCoba
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        //
        // Akun
        //
        public virtual DbSet<Akun> Akun { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Loker> Loker { get; set; }
        public virtual DbSet<Lomba> Lomba { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        //
        // Experience
        //
        public virtual DbSet<SkillBisnis> Bisnis { get; set; }
        public virtual DbSet<SkillDesign> Desain { get; set; }
        public virtual DbSet<SkillIT> IT { get; set; }
        public virtual DbSet<SkillJurnalisme> Jurnalisme { get; set; }
        public virtual DbSet<SkillRiset> Riset { get; set; }
        public virtual DbSet<SkillUmum> Umum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
