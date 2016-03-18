namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.ETL_CTRL")]
    public partial class ETL_CTRL
    {
        [Key]
        [StringLength(32)]
        public string ETL_CTRL_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ETL_NAME { get; set; }

        [StringLength(100)]
        public string ETL_DESCP { get; set; }

        [Required]
        [StringLength(30)]
        public string SOURCE_TABLE { get; set; }

        [Required]
        [StringLength(30)]
        public string DEST_TABLE { get; set; }

        [StringLength(1)]
        public string ETL_ACTIVE { get; set; }

        public decimal? LAST_REC_SEQ_NO { get; set; }

        public DateTime? LAST_PROC_DT { get; set; }

        public DateTime? CREATED_DT { get; set; }
    }
}
