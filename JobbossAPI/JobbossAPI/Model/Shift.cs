namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shift")]
    public partial class Shift
    {
        [Key]
        [Column("Shift")]
        public Guid Shift1 { get; set; }

        [StringLength(20)]
        public string Shift_Name { get; set; }

        public double? DT_Rate { get; set; }

        public double? Daily_DT_Threshold { get; set; }

        public double? Daily_OT_Threshold { get; set; }

        public double? Weekly_DT_Threshold { get; set; }

        public double? Weekly_OT_Threshold { get; set; }

        public double? Holiday_Rate { get; set; }

        public double? OT_Rate { get; set; }

        public int? Round_Direction { get; set; }

        public int? Round_Increment { get; set; }

        public bool? Saturday_Holiday { get; set; }

        public bool? Sunday_Holiday { get; set; }

        public DateTime? Last_Updated { get; set; }

        public bool? Round_Job_Time { get; set; }

        public double? CutOff_Hrs { get; set; }
    }
}
