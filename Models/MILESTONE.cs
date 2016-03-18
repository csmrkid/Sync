namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.MILESTONE")]
    public partial class MILESTONE
    {
        [Key]
        [StringLength(32)]
        public string MILESTONE_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MILESTONE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string MILESTONE_NAME { get; set; }

        [StringLength(50)]
        public string MILESTONE_DESCP { get; set; }

        [Required]
        [StringLength(1)]
        public string DISP_FLAG { get; set; }

        public int? DISP_SORTING_AIR { get; set; }

        [StringLength(3)]
        public string PL_EVENT_CODE { get; set; }

        [StringLength(50)]
        public string PL_EVENT_NAME { get; set; }

        [Required]
        [StringLength(1)]
        public string MILESTONE_ACTIVE { get; set; }

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

        [StringLength(1)]
        public string IS_AIR { get; set; }

        [StringLength(1)]
        public string IS_SEA { get; set; }

        public int? DISP_SORTING_SEA { get; set; }

        [StringLength(1)]
        public string EI_FLAG { get; set; }

        [StringLength(1)]
        public string MANDATORY_FLAG { get; set; }
    }
}
