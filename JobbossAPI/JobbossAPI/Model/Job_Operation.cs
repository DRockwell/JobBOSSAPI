namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job_Operation
    {
        [Key]
        public int Job_OperationKey { get; set; }

        [Column("Job_Operation")]
        public int? Job_Operation1 { get; set; }

        [StringLength(10)]
        public string Vendor { get; set; }

        [StringLength(10)]
        public string Work_Center { get; set; }

        [Required]
        [StringLength(10)]
        public string Job { get; set; }

        [StringLength(10)]
        public string Operation_Service { get; set; }

        [Required]
        [StringLength(10)]
        public string WC_Vendor { get; set; }

        public bool Inside_Oper { get; set; }

        public short Sequence { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        public double? Priority { get; set; }

        [StringLength(8)]
        public string Run_Method { get; set; }

        public double? Run { get; set; }

        public double? Est_Run_Per_Part { get; set; }

        public double? Efficiency_Pct { get; set; }

        public double? Attended_Pct { get; set; }

        public double? Queue_Hrs { get; set; }

        public double? Est_Total_Hrs { get; set; }

        public double? Est_Setup_Hrs { get; set; }

        public double? Est_Run_Hrs { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Setup_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Run_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_GA_Burden { get; set; }

        public int? Est_Required_Qty { get; set; }

        public double Est_Unit_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Addl_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Total_Cost { get; set; }

        public double Deferred_Qty { get; set; }

        public double? Act_Setup_Hrs { get; set; }

        public double? Act_Run_Hrs { get; set; }

        public int? Act_Run_Qty { get; set; }

        public int? Act_Scrap_Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Setup_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Run_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_GA_Burden { get; set; }

        public double Act_Unit_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Addl_Cost { get; set; }

        [StringLength(15)]
        public string Addl_Cost_Desc { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Total_Cost { get; set; }

        public double? Setup_Pct_Complete { get; set; }

        public double? Run_Pct_Complete { get; set; }

        public double? Rem_Run_Hrs { get; set; }

        public double? Rem_Setup_Hrs { get; set; }

        public double? Rem_Total_Hrs { get; set; }

        [StringLength(3)]
        public string Overlap_Method { get; set; }

        public double? Overlap { get; set; }

        public double? Overlap_Qty { get; set; }

        public double? Est_Ovl_Hrs { get; set; }

        public short? Lead_Days { get; set; }

        public DateTime? Sched_Ovl_Start_OLD { get; set; }

        public double? Sched_Ovl_Start_Hr_OLD { get; set; }

        public DateTime? Sched_Start { get; set; }

        public double? Sched_Start_Hr_OLD { get; set; }

        public DateTime? Sched_End { get; set; }

        public double? Sched_End_Hr_OLD { get; set; }

        public bool Schedule_Exception_OLD { get; set; }

        public DateTime? Due_Date { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [Column(TypeName = "money")]
        public decimal Minimum_Chg_Amt { get; set; }

        [StringLength(4)]
        public string Cost_Unit { get; set; }

        public double Cost_Unit_Conv { get; set; }

        public double Currency_Conv_Rate { get; set; }

        public int? Trade_Currency { get; set; }

        public bool Fixed_Rate { get; set; }

        public DateTime? Trade_Date { get; set; }

        public int? Rwk_Quantity { get; set; }

        public double? Rwk_Setup_Hrs { get; set; }

        public double? Rwk_Run_Hrs { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rwk_Setup_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rwk_Run_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rwk_Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rwk_Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rwk_GA_Burden { get; set; }

        public double? Rwk_Scrap_Qty { get; set; }

        [Column(TypeName = "text")]
        public string Note_Text { get; set; }

        public DateTime Last_Updated { get; set; }

        [StringLength(50)]
        public string Holder_ID { get; set; }

        [StringLength(50)]
        public string Op_Group { get; set; }

        public double? Act_Run_Labor_Hrs { get; set; }

        public int? Setup_Qty { get; set; }

        public int? Run_Qty { get; set; }

        public double? Rwk_Run_Labor_Hrs { get; set; }

        public int? Rwk_Setup_Qty { get; set; }

        public int? Rwk_Run_Qty { get; set; }

        public double? Act_Setup_Labor_Hrs { get; set; }

        public double? Rwk_Setup_Labor_Hrs { get; set; }

        [Column(TypeName = "text")]
        public string Floor_Notes { get; set; }

        public Guid ObjectID { get; set; }

        public Guid? Job_OID { get; set; }

        public double? Sched_Resources { get; set; }

        public double? Lag_Hours { get; set; }

        public Guid? WorkCenter_OID { get; set; }

        public bool? Manual_Start_Lock { get; set; }

        public bool? Manual_Stop_Lock { get; set; }

        public bool? Priority_Zero_Lock { get; set; }

        public bool? Firm_Zone_Lock { get; set; }

        public Guid? SB_Orig_OID { get; set; }

        public double? SB_Setup_Hrs { get; set; }

        public double? SB_Run_Hrs { get; set; }

        public double? SB_Run { get; set; }

        [StringLength(8)]
        public string SB_RunMethod { get; set; }

        public double? SB_Efficiency { get; set; }

        public DateTime? Actual_Start { get; set; }

        [StringLength(50)]
        public string Last_Updated_By { get; set; }

        public virtual Job Job1 { get; set; }

        public virtual Work_Center Work_Center1 { get; set; }
    }
}
