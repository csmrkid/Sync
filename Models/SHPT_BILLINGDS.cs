namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_BILLINGDS")]
    public partial class SHPT_BILLINGDS
    {
        [Key]
        [StringLength(32)]
        public string SHPT_BILLINGDS_ID { get; set; }

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
        [StringLength(30)]
        public string INV_NO { get; set; }

        [Required]
        [StringLength(10)]
        public string CHRG_CODE { get; set; }

        [StringLength(50)]
        public string CHRG_DESCP { get; set; }

        public decimal? INV_AMT_L { get; set; }

        public decimal? INV_AMT_USD { get; set; }

        [StringLength(3)]
        public string DEP { get; set; }

        [StringLength(3)]
        public string CHRG_DEP { get; set; }

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

        [StringLength(3)]
        public string INV_CRNCY { get; set; }
    }
}
