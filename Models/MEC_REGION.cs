namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.MEC_REGION")]
    public partial class MEC_REGION
    {
        [Key]
        [StringLength(32)]
        public string MEC_REGION_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string MEC_REGION_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string MEC_REGION_NAME { get; set; }

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
