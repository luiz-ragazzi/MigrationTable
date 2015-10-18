namespace MigrationTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        [Key]
        [Column("document")]
        public int document1 { get; set; }

        [StringLength(100)]
        public string author { get; set; }

        [StringLength(100)]
        public string author_email { get; set; }

        [Required]
        [StringLength(100)]
        public string title { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime date_posted { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? publish_start { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? publish_end { get; set; }

        [Column("abstract")]
        [Required]
        [StringLength(2000)]
        public string _abstract { get; set; }

        [StringLength(1000)]
        public string keywords { get; set; }

        [StringLength(200)]
        public string link { get; set; }

        public int visible_global { get; set; }

        public int quicklinks { get; set; }

        [StringLength(200)]
        public string filename { get; set; }

        [Column(TypeName = "image")]
        public byte[] data { get; set; }

        [StringLength(6)]
        public string datatype { get; set; }

        public int folder { get; set; }

        public int set_lo { get; set; }

        public int set_hi { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] fulltexttime { get; set; }

        public int? team { get; set; }

        public int? height { get; set; }

        public int active { get; set; }

        public int? parent { get; set; }

        public int? policyguidance { get; set; }

        public int? datasize { get; set; }

        [Column(TypeName = "image")]
        public byte[] photograph { get; set; }

        public int category { get; set; }

        public int worldnews { get; set; }

        [Column(TypeName = "image")]
        public byte[] thumbnail { get; set; }
    }
}
