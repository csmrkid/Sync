namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.ETL_ERR")]
    public partial class ETL_ERR
    {
        [Key]
        [StringLength(32)]
        public string ETL_ERR_ID { get; set; }

        public DateTime? ETL_ERR_DT { get; set; }

        [StringLength(50)]
        public string ETL_NAME { get; set; }

        [StringLength(50)]
        public string SQL_CODE { get; set; }

        [StringLength(500)]
        public string SQL_ERR_MSG { get; set; }

        public decimal? ERR_REC_SEQ_NO { get; set; }

        [StringLength(50)]
        public string KEY_FIELD_01 { get; set; }

        [StringLength(50)]
        public string KEY_FIELD_02 { get; set; }

        [StringLength(50)]
        public string KEY_FIELD_03 { get; set; }

        [StringLength(50)]
        public string KEY_FIELD_04 { get; set; }

        [StringLength(50)]
        public string KEY_FIELD_05 { get; set; }
    }
}
