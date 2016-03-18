namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_CURSTATUS")]
    public partial class SHPT_CURSTATUS
    {
        [Key]
        [StringLength(32)]
        public string SHPT_CURSTATUS_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string MODE_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string AWB_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string AWB_NO { get; set; }

        public DateTime? BK_DT { get; set; }

        [StringLength(8)]
        public string BK_D { get; set; }

        public DateTime? APU_DT { get; set; }

        [StringLength(8)]
        public string APU_D { get; set; }

        public DateTime? ETD_DT { get; set; }

        [StringLength(8)]
        public string ETD_D { get; set; }

        public DateTime? ATD_DT { get; set; }

        [StringLength(8)]
        public string ATD_D { get; set; }

        public DateTime? ETA_DT { get; set; }

        [StringLength(8)]
        public string ETA_D { get; set; }

        public DateTime? ATA_DT { get; set; }

        [StringLength(8)]
        public string ATA_D { get; set; }

        public DateTime? CC_IMP_DT { get; set; }

        [StringLength(8)]
        public string CC_IMP_D { get; set; }

        public DateTime? DOC_RLS_DT { get; set; }

        [StringLength(8)]
        public string DOC_RLS_D { get; set; }

        public DateTime? OFD_DT { get; set; }

        [StringLength(8)]
        public string OFD_D { get; set; }

        public DateTime? POD_DT { get; set; }

        [StringLength(8)]
        public string POD_D { get; set; }

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

        [StringLength(10)]
        public string CUR_STATUS_CODE { get; set; }

        public DateTime? CUR_STATUS_DT { get; set; }

        [StringLength(50)]
        public string CUR_SIGNED_BY { get; set; }

        public DateTime? DELV_DT { get; set; }

        [StringLength(8)]
        public string DELV_D { get; set; }

        [StringLength(1)]
        public string SVC_COMPLETE_FLAG { get; set; }
    }
}
