namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job_Operation_Time
    {
        public int Job_Operation { get; set; }

        [Required]
        [StringLength(6)]
        public string Employee { get; set; }

        public DateTime Work_Date { get; set; }

        public double? Act_Setup_Hrs { get; set; }

        public double? Act_Run_Hrs { get; set; }

        public int? Act_Run_Qty { get; set; }

        public int? Act_Scrap_Qty { get; set; }

        public double? Overtime_Hrs { get; set; }

        public double Setup_Overtime_Hrs { get; set; }

        public double? Overtime_Factor { get; set; }

        public bool Operation_Complete { get; set; }

        public double? Attended_Pct { get; set; }

        public bool Rework_Time { get; set; }

        public double? Setup_Pct_Complete { get; set; }

        public double? Run_Pct_Complete { get; set; }

        public double? Setup_Labor_Rate { get; set; }

        public double? Run_Labor_Rate { get; set; }

        public double? Labor_Burden { get; set; }

        public double Setup_Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? GA_Burden { get; set; }

        [Column(TypeName = "text")]
        public string Note_Text { get; set; }

        public DateTime Last_Updated { get; set; }

        public short Entry_Type { get; set; }

        [Key]
        [Column("Job_Operation_Time")]
        [StringLength(50)]
        public string Job_Operation_Time1 { get; set; }

        [StringLength(25)]
        public string Scrap_Code { get; set; }

        [StringLength(25)]
        public string Rwk_Code { get; set; }

        [StringLength(10)]
        public string WC { get; set; }

        [StringLength(50)]
        public string Op_Group { get; set; }

        public int? Act_Setup_Qty { get; set; }

        public double? Act_Run_Labor_Hrs { get; set; }

        public double? Act_Setup_Labor_Hrs { get; set; }

        public short? Status { get; set; }

        public double? Overtime_Hrs_7x { get; set; }

        public int? User_Values { get; set; }

        public Guid ObjectID { get; set; }

        public Guid? Job_Operation_OID { get; set; }

        public Guid? Employee_OID { get; set; }
    }
}
