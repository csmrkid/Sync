namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_DOCUMENTS")]
    public partial class SHPT_DOCUMENTS
    {
        [Key]
        [StringLength(32)]
        public string SHPT_DOCUMENTS_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string MODE_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string AWB_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string AWB_NO { get; set; }

        [Required]
        [StringLength(10)]
        public string DOC_CODE { get; set; }

        [StringLength(100)]
        public string DOC_REMARK { get; set; }

        public DateTime? CREATED_DT { get; set; }

        [StringLength(32)]
        public string CREATED_USER_ID { get; set; }

        [StringLength(10)]
        public string CREATED_VIA { get; set; }

        [Required]
        public byte[] DOC_FILE { get; set; }

        [Required]
        [StringLength(100)]
        public string DOC_FILENAME { get; set; }

        [Required]
        [StringLength(5)]
        public string DOC_EXT { get; set; }

        [Required]
        [StringLength(100)]
        public string CONTENT_TYPE { get; set; }

        [StringLength(100)]
        public string CONTENT_SUB_TYPE { get; set; }
    }
}
