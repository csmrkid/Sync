namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.STATION_BRANCH")]
    public partial class STATION_BRANCH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string STATIONBRANCH_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string STATION_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string STATION_CODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string BRANCH_CODE { get; set; }

        [StringLength(10)]
        public string PRODUCT_CODE { get; set; }

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
