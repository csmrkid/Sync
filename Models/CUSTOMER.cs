namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.CUSTOMER")]
    public partial class CUSTOMER
    {
        [Key]
        [StringLength(32)]
        public string CUSTOMER_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CUSTOMER_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_NAME1 { get; set; }

        [StringLength(50)]
        public string CUSTOMER_NAME2 { get; set; }

        [Required]
        [StringLength(10)]
        public string PARENT_CODE { get; set; }

        [StringLength(50)]
        public string ADDR1 { get; set; }

        [StringLength(50)]
        public string ADDR2 { get; set; }

        [StringLength(50)]
        public string ADDR3 { get; set; }

        [StringLength(50)]
        public string ADDR4 { get; set; }

        [Required]
        [StringLength(3)]
        public string CITY_CODE { get; set; }

        [StringLength(2)]
        public string STATE_CODE { get; set; }

        [StringLength(20)]
        public string POSTAL { get; set; }

        [Required]
        [StringLength(2)]
        public string COUNTRY_CODE { get; set; }

        [StringLength(1)]
        public string IS_CUST { get; set; }

        [StringLength(1)]
        public string IS_SHPR { get; set; }

        [StringLength(1)]
        public string IS_CNEE { get; set; }

        [StringLength(1)]
        public string IS_AGENT { get; set; }

        [StringLength(1)]
        public string IS_MORRISON { get; set; }

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

        [StringLength(2)]
        public string NATURE_CODE { get; set; }

        [StringLength(15)]
        public string MILESTONES_CTRL_CODE { get; set; }
    }
}
