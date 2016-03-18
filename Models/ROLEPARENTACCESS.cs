namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.ROLEPARENTACCESS")]
    public partial class ROLEPARENTACCESS
    {
        [Key]
        [StringLength(32)]
        public string ROLEPARENTACC_ID { get; set; }

        [StringLength(20)]
        public string ROLE_CODE { get; set; }

        [StringLength(10)]
        public string PARENT_CODE { get; set; }

        public DateTime? CREATED_DT { get; set; }

        [StringLength(32)]
        public string CREATED_USER_ID { get; set; }

        [StringLength(10)]
        public string CREATED_VIA { get; set; }
    }
}
