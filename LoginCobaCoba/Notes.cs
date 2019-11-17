namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notes")]
    public partial class Notes
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Akun { get; set; }

        [StringLength(50)]
        public string NameEvent { get; set; }

        [StringLength(10)]
        public string StatusEvent { get; set; }

        [StringLength(40)]
        public string NoteEvent { get; set; }

        [StringLength(50)]
        public string NameLoker { get; set; }

        [StringLength(10)]
        public string StatusLoker { get; set; }

        [StringLength(40)]
        public string NoteLoker { get; set; }

        [StringLength(50)]
        public string NameLomba { get; set; }

        [StringLength(2)]
        public string ProgressLomba { get; set; }

        [StringLength(40)]
        public string NoteLomba { get; set; }
    }
}
