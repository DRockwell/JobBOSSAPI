namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Code
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string Code { get; set; }

        public DateTime? Date1 { get; set; }

        public double? Numeric1 { get; set; }

        public double? Numeric2 { get; set; }

        public double? Numeric3 { get; set; }

        public double? Numeric4 { get; set; }

        [StringLength(100)]
        public string Text1 { get; set; }

        [StringLength(20)]
        public string Text2 { get; set; }

        [Column(TypeName = "text")]
        public string Text3 { get; set; }

        public DateTime Last_Updated { get; set; }

        [StringLength(100)]
        public string Text4 { get; set; }

        public Guid ObjectID { get; set; }
    }
}
