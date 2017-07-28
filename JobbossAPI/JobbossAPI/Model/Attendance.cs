namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        [Key]
        [Column("Attendance")]
        [StringLength(50)]
        public string Attendance1 { get; set; }

        [StringLength(6)]
        public string Employee { get; set; }

        public DateTime? Work_Date { get; set; }

        public DateTime? Login { get; set; }

        public DateTime? Adjusted_Login { get; set; }

        public DateTime? Logout { get; set; }

        public DateTime? Adjusted_Logout { get; set; }

        public double? Regular_Minutes { get; set; }

        public double? OT_Minutes { get; set; }

        public double? DoubleOT_Minutes { get; set; }

        public double? Break_Minutes { get; set; }

        public int? Attendance_Type { get; set; }

        public bool? Lock_Times { get; set; }

        public int? Source { get; set; }

        public DateTime? Last_Updated { get; set; }
    }
}
