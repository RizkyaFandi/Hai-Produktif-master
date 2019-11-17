namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
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
        [StringLength(400)]
        public string Desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [StringLength(10)]
        public string Minat { get; set; }
    }
}
