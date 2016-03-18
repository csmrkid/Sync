namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.SHPT_NOTIDS")]
    public partial class SHPT_NOTIDS
    {
        [Key]
        [StringLength(32)]
        public string SHPT_NOTIDS_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string SHPT_NOTIMS_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string STATUS_CODE { get; set; }

        public byte? STATUS_SEQ_NO { get; set; }

        [StringLength(8)]
        public string STATUS_D { get; set; }

        [StringLength(4)]
        public string STATUS_T { get; set; }

        [StringLength(8)]
        public string STATUS_D_OLD { get; set; }

        [StringLength(4)]
        public string STATUS_T_OLD { get; set; }

        [StringLength(1)]
        public string IS_CHANGE { get; set; }

        public DateTime? CREATED_DT { get; set; }

        [StringLength(32)]
        public string CREATED_USER_ID { get; set; }

        [StringLength(10)]
        public string CREATED_VIA { get; set; }
    }
}
