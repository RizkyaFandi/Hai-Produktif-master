namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table2
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Event_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Tanggal { get; set; }

        [Required]
        [StringLength(20)]
        public string Deskripsi { get; set; }
    }
}
