namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lomba")]
    public partial class Lomba
    {
        [Key]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Auth { get; set; }

        [Column(TypeName = "date")]
        public DateTime Published { get; set; }

        [Required]
        [StringLength(300)]
        public string Desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime Deadline { get; set; }

        [Required]
        [StringLength(20)]
        public string CP { get; set; }

        [Required]
        [StringLength(15)]
        public string Minat { get; set; }
    }
}
