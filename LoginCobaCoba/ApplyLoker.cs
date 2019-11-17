namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyLoker")]
    public partial class ApplyLoker
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nomor { get; set; }

        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Applied { get; set; }
    }
}
