namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkillJurnalisme")]
    public partial class SkillJurnalisme
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Nomor { get; set; }

        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(50)]
        public string History { get; set; }

        [StringLength(50)]
        public string Achievements { get; set; }
    }
}
