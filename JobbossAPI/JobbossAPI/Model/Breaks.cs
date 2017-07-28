namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Breaks
    {
        [Key]
        [Column("Breaks")]
        public Guid Breaks1 { get; set; }

        [StringLength(50)]
        public string Break_Name { get; set; }

        public DateTime? End_Time { get; set; }

        public DateTime? Start_Time { get; set; }

        public Guid? Shift { get; set; }

        public int? PostEnd_Grace { get; set; }

        public int? PostStart_Grace { get; set; }

        public int? PreEnd_Grace { get; set; }

        public int? PreStart_Grace { get; set; }

        public bool Deduct_Job_Time { get; set; }

        public DateTime? Last_Updated { get; set; }

        public bool? Schedule_Break { get; set; }

        public DateTime? Created_Time { get; set; }
    }
}
