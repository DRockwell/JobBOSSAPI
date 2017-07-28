namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shift_Day
    {
        [Key]
        [Column("Shift_Day")]
        public Guid Shift_Day1 { get; set; }

        public Guid? Shift { get; set; }

        public DateTime? End_Time { get; set; }

        public int? PostEnd_Grace { get; set; }

        public int? PostStart_Grace { get; set; }

        public int? PreEnd_Grace { get; set; }

        public int? PreStart_Grace { get; set; }

        public DateTime? Start_Time { get; set; }

        public int? Sequence { get; set; }

        public DateTime? Last_Updated { get; set; }

        public bool? First_Day { get; set; }
    }
}
