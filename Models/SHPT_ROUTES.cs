namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_ROUTES")]
    public partial class SHPT_ROUTES
    {
        [Key]
        [StringLength(32)]
        public string SHPT_ROUTES_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string MODE_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string AWB_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string AWB_NO { get; set; }

        public byte SEQ_NO { get; set; }

        [StringLength(20)]
        public string MAWB_NO { get; set; }

        [StringLength(17)]
        public string FLIGHT_NO { get; set; }

        [StringLength(3)]
        public string FR_PORT_CODE { get; set; }

        [StringLength(2)]
        public string FR_COUNTRY_CODE { get; set; }

        [StringLength(3)]
        public string TO_PORT_CODE { get; set; }

        [StringLength(2)]
        public string TO_COUNTRY_CODE { get; set; }

        public DateTime? ETD_DT { get; set; }

        public DateTime? ATD_DT { get; set; }

        public DateTime? ETA_DT { get; set; }

        public DateTime? ATA_DT { get; set; }

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

        [StringLength(50)]
        public string VESSEL_NAME { get; set; }

        [StringLength(12)]
        public string VOYAGE_CODE { get; set; }

        [StringLength(16)]
        public string VOYAGE_NAME { get; set; }
    }
}
