namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.IR_REASON")]
    public partial class IR_REASON
    {
        [Key]
        [StringLength(3)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string CODE_DESCP { get; set; }
    }
}
