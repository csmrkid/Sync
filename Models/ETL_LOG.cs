namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.ETL_LOG")]
    public partial class ETL_LOG
    {
        [Key]
        [StringLength(32)]
        public string ETL_LOG_ID { get; set; }

        public DateTime ETL_PROC_DT { get; set; }

        [Required]
        [StringLength(50)]
        public string ETL_NAME { get; set; }

        public decimal FROM_REC_SEQ_NO { get; set; }

        public decimal TO_REC_SEQ_NO { get; set; }
    }
}
