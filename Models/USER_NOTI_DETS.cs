namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.USER_NOTI_DETS")]
    public partial class USER_NOTI_DETS
    {
        [Key]
        [StringLength(32)]
        public string USER_NOTI_DETS_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string USER_NOTI_CTRL_ID { get; set; }

        [StringLength(10)]
        public string STATUS_CODE { get; set; }

        [StringLength(1)]
        public string STATUS_NOTI_ACTIVE { get; set; }

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

        public byte? STATUS_SEQ_NO { get; set; }

        [StringLength(8)]
        public string STATUS_D_LAST { get; set; }

        [StringLength(4)]
        public string STATUS_T_LAST { get; set; }
    }
}
