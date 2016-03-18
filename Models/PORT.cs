namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.PORT")]
    public partial class PORT
    {
        [Key]
        [StringLength(32)]
        public string PORT_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string PORT_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string PORT_NAME { get; set; }

        [Required]
        [StringLength(3)]
        public string CITY_CODE { get; set; }

        [StringLength(2)]
        public string STATE_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string COUNTRY_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string IATA_CODE { get; set; }

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

        public decimal? TZONE_OFFSET { get; set; }

        public decimal? LATITUDE { get; set; }

        public decimal? LONGITUDE { get; set; }
    }
}
