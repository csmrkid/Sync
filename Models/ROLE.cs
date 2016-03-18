namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.ROLE")]
    public partial class ROLE
    {
        [Key]
        [StringLength(32)]
        public string ROLE_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string ROLE_CODE { get; set; }

        [StringLength(50)]
        public string ROLE_NAME { get; set; }

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

        [StringLength(1)]
        public string IS_MEC { get; set; }
    }
}
