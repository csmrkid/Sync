namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SEAWB")]
    public partial class SEAWB
    {
        [Key]
        [StringLength(32)]
        public string SEAWB_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BL_NO { get; set; }

        [StringLength(20)]
        public string MBL_NO { get; set; }

        [StringLength(20)]
        public string BOOKING_NO { get; set; }

        [StringLength(20)]
        public string QUOT_NO { get; set; }

        [StringLength(3)]
        public string INCOTERMS_CODE { get; set; }

        [StringLength(2)]
        public string FRT_TYPE_CODE { get; set; }

        [StringLength(3)]
        public string POR_PORT_CODE { get; set; }

        [StringLength(2)]
        public string POR_COUNTRY_CODE { get; set; }

        [StringLength(3)]
        public string POL_PORT_CODE { get; set; }

        [StringLength(2)]
        public string POL_COUNTRY_CODE { get; set; }

        [StringLength(3)]
        public string POD_PORT_CODE { get; set; }

        [StringLength(2)]
        public string POD_COUNTRY_CODE { get; set; }

        [StringLength(3)]
        public string DLV_PORT_CODE { get; set; }

        [StringLength(2)]
        public string DLV_COUNTRY_CODE { get; set; }

        [StringLength(10)]
        public string CUSTOMER_CODE { get; set; }

        [StringLength(10)]
        public string SHPR_CODE { get; set; }

        [StringLength(10)]
        public string CNEE_CODE { get; set; }

        [StringLength(10)]
        public string CARRIER_CODE { get; set; }

        [StringLength(40)]
        public string COMMODITY { get; set; }

        [StringLength(50)]
        public string VESSEL_NAME { get; set; }

        [StringLength(12)]
        public string VOYAGE_CODE { get; set; }

        [StringLength(16)]
        public string VOYAGE_NAME { get; set; }

        public int? PKG_QTY { get; set; }

        [StringLength(3)]
        public string PKG_UNIT_CODE { get; set; }

        public decimal? GW { get; set; }

        [StringLength(3)]
        public string GW_UNIT_CODE { get; set; }

        public decimal? CBM { get; set; }

        public DateTime? BL_CREATED_DT { get; set; }

        public DateTime? SHIP_DT { get; set; }

        public DateTime? DUE_DT { get; set; }

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

        [StringLength(10)]
        public string CUR_STATUS_CODE { get; set; }

        [StringLength(20)]
        public string LOT_NO { get; set; }

        public decimal? TEU { get; set; }

        [StringLength(6)]
        public string SVC_TYPE_CODE { get; set; }

        public DateTime? CUR_STATUS_DT { get; set; }

        [StringLength(50)]
        public string CUR_SIGNED_BY { get; set; }

        [StringLength(1)]
        public string SVC_COMPLETE_FLAG { get; set; }

        [StringLength(1)]
        public string MEC_BROKER_FLAG { get; set; }
    }
}
