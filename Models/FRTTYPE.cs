namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPOWN.FRTTYPE")]
    public partial class FRTTYPE
    {
        [Key]
        [StringLength(2)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string CODE_DESCP { get; set; }
    }
}
