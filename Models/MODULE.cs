namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.MODULE")]
    public partial class MODULE
    {
        [Key]
        [StringLength(32)]
        public string MODULE_ID { get; set; }

        [StringLength(30)]
        public string MODULE_CODE { get; set; }

        [StringLength(50)]
        public string MODULE_NAME { get; set; }

        [StringLength(50)]
        public string MODULE_DESCP { get; set; }

        public short? MODULE_SEQ_NO { get; set; }
    }
}
