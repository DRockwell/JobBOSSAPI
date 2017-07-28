namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Material_Req
    {
        [Key]
        public int Material_ReqKey { get; set; }

        [Column("Material_Req")]
        public int? Material_Req1 { get; set; }

        public int? Job_Operation { get; set; }

        [Required]
        [StringLength(10)]
        public string Job { get; set; }

        [StringLength(30)]
        public string Material { get; set; }

        [StringLength(10)]
        public string Vendor { get; set; }

        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        [StringLength(1)]
        public string Pick_Buy_Indicator { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(1)]
        public string Quantity_Per_Basis { get; set; }

        public double? Quantity_Per { get; set; }

        [Required]
        [StringLength(4)]
        public string UofM { get; set; }

        public double Deferred_Qty { get; set; }

        public double? Est_Qty { get; set; }

        public double? Est_Unit_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Addl_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Total_Cost { get; set; }

        [StringLength(25)]
        public string Addl_Cost_Desc { get; set; }

        public double? Act_Qty { get; set; }

        public double? Act_Unit_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Addl_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Total_Cost { get; set; }

        public double? Part_Length { get; set; }

        public double? Part_Width { get; set; }

        public double? Bar_End { get; set; }

        public double? Cutoff { get; set; }

        public double? Facing { get; set; }

        public double? Bar_Length { get; set; }

        public short? Lead_Days { get; set; }

        public double Currency_Conv_Rate { get; set; }

        public int? Trade_Currency { get; set; }

        public bool Fixed_Rate { get; set; }

        public DateTime? Trade_Date { get; set; }

        public bool Certs_Required { get; set; }

        public bool Manual_Link { get; set; }

        public DateTime? Due_Date { get; set; }

        public DateTime? Sched_Start_Date { get; set; }

        public DateTime? Sched_End_Date { get; set; }

        [StringLength(30)]
        public string Vendor_Reference { get; set; }

        [Column(TypeName = "text")]
        public string Note_Text { get; set; }

        public DateTime Last_Updated { get; set; }

        [StringLength(50)]
        public string Holder_ID { get; set; }

        [StringLength(4)]
        public string Cost_UofM { get; set; }

        public double? Cost_Unit_Conv { get; set; }

        public double? Quantity_Multiplier { get; set; }

        [StringLength(30)]
        public string Drawing_ID { get; set; }

        public short? Res_Type { get; set; }

        [StringLength(50)]
        public string Res_ID { get; set; }

        public double? Res_Qty { get; set; }

        public bool? Partial_Res { get; set; }

        public Guid ObjectID { get; set; }

        public Guid? Job_Operation_OID { get; set; }

        public Guid? Job_OID { get; set; }

        public bool? Affects_Schedule { get; set; }

        public Guid? Material_OID { get; set; }

        public bool Rounded { get; set; }

        public virtual Job Job1 { get; set; }
    }
}
