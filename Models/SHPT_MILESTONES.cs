namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_MILESTONES")]
    public partial class SHPT_MILESTONES
    {
        [Key]
        [StringLength(32)]
        public string SHPT_MILESTONES_ID { get; set; }

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
        public string STATUS_CODE { get; set; }

        public DateTime STATUS_DT { get; set; }

        [StringLength(50)]
        public string SIGNED_BY { get; set; }

        [StringLength(3)]
        public string CITY_CODE { get; set; }

        [StringLength(2)]
        public string STATE_CODE { get; set; }

        [StringLength(2)]
        public string COUNTRY_CODE { get; set; }

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

        public byte SEQ_NO { get; set; }

        [StringLength(100)]
        public string REMARK1 { get; set; }

        [StringLength(3)]
        public string IR_REASON_CODE { get; set; }
    }
}
