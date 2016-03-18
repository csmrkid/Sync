namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.PL_BLSTATUS")]
    public partial class PL_BLSTATUS
    {
        [StringLength(20)]
        public string MAWB_NO { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string AWB_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string DEP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string STATUS_CD { get; set; }

        [StringLength(8)]
        public string PROCESS_DATE { get; set; }

        [StringLength(6)]
        public string PROCESS_TIME { get; set; }

        [StringLength(10)]
        public string PROCESS_BY { get; set; }

        [StringLength(60)]
        public string REMARK { get; set; }

        public DateTime? CREATED_DT { get; set; }

        [StringLength(32)]
        public string CREATED_USER_ID { get; set; }

        [StringLength(10)]
        public string CREATED_VIA { get; set; }
    }
}
