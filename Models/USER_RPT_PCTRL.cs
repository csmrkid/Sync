namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.USER_RPT_PCTRL")]
    public partial class USER_RPT_PCTRL
    {
        [Key]
        [StringLength(32)]
        public string USER_RPT_PCTRL_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string USER_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string RPT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string RPT_CODE { get; set; }

        [StringLength(1)]
        public string PROFILE_ACTIVE { get; set; }

        [Required]
        [StringLength(3)]
        public string MODE_CODE { get; set; }

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
