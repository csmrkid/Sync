namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_PARTNERS")]
    public partial class SHPT_PARTNERS
    {
        [Key]
        [StringLength(32)]
        public string SHPT_PARTNERS_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string MODE_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string AWB_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string AWB_NO { get; set; }

        public short SEQ_NO { get; set; }

        [StringLength(20)]
        public string PARTNER_QFR_CODE { get; set; }

        [StringLength(10)]
        public string PARTNER_CODE { get; set; }

        [StringLength(10)]
        public string DEP_CODE { get; set; }

        public DateTime? CREATED_DT { get; set; }

        [StringLength(32)]
        public string CREATED_USER_ID { get; set; }

        [StringLength(10)]
        public string CREATED_VIA { get; set; }

        public DateTime? LAST_MODIFIED_DT { get; set; }

        [StringLength(32)]
        public string LAST_MODIFIED_USER_ID { get; set; }

        [StringLength(10)]
        public string LAST_MODIFIED_VIA { get; set; }
    }
}
