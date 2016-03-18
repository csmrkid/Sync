namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.USER_RPT_PROFILE")]
    public partial class USER_RPT_PROFILE
    {
        [Key]
        [StringLength(32)]
        public string USER_RPT_PROFILE_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string USER_RPT_PROFILE_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string USER_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string RPT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string RPT_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string COL_ACTIVE { get; set; }

        [Required]
        [StringLength(50)]
        public string COL_QRY_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string COL_DISP_NAME { get; set; }

        public byte COL_DISP_WIDTH { get; set; }

        [Required]
        [StringLength(10)]
        public string COL_DISP_FCOLOR { get; set; }

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
        public string MODE_CODE { get; set; }

        public byte? COL_DISP_SORTING { get; set; }

        [StringLength(10)]
        public string COL_DISP_BCOLOR { get; set; }

        [StringLength(32)]
        public string REF_RPT_PROFILE_ID { get; set; }
    }
}
