namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Note
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Akun { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Count { get; set; }

        [StringLength(50)]
        public string Activity { get; set; }
    }
}
