namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.ROLEMODULEACCESS")]
    public partial class ROLEMODULEACCESS
    {
        [Key]
        [StringLength(32)]
        public string ROLEMODULEACC_ID { get; set; }

        [StringLength(20)]
        public string ROLE_CODE { get; set; }

        [StringLength(30)]
        public string MODULE_CODE { get; set; }
    }
}
