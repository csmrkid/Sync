namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_CONTAINERS")]
    public partial class SHPT_CONTAINERS
    {
        [Key]
        [StringLength(32)]
        public string SHPT_CONTAINERS_ID { get; set; }

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
        [StringLength(20)]
        public string CONTAINER_NO { get; set; }

        [StringLength(6)]
        public string CONTAINER_TYPE { get; set; }

        [StringLength(3)]
        public string SERVICE_TYPE_CODE { get; set; }

        public int? PKG_QTY { get; set; }

        [StringLength(3)]
        public string PKG_UNIT_CODE { get; set; }

        public decimal? GW { get; set; }

        [StringLength(3)]
        public string GW_UNIT_CODE { get; set; }

        public decimal? CBM { get; set; }

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
