namespace LoginCobaCoba
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Experience")]
    public partial class Experience
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Akun { get; set; }

        [StringLength(50)]
        public string Event1 { get; set; }

        [StringLength(50)]
        public string Event2 { get; set; }

        [StringLength(50)]
        public string Event3 { get; set; }

        [StringLength(50)]
        public string Lomba1 { get; set; }

        [StringLength(50)]
        public string Lomba2 { get; set; }

        [StringLength(50)]
        public string Lomba3 { get; set; }

        [StringLength(50)]
        public string Loker1 { get; set; }

        [StringLength(50)]
        public string Loker2 { get; set; }

        [StringLength(50)]
        public string Loker3 { get; set; }

        [StringLength(50)]
        public string ApplyLoker1 { get; set; }

        [StringLength(50)]
        public string ApplyLoker2 { get; set; }

        [StringLength(50)]
        public string ApplyLoker3 { get; set; }
    }
}
