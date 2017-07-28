namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            Material_Req = new HashSet<Material_Req>();
            Job_Operation = new HashSet<Job_Operation>();
        }

        [Key]
        [Column("Job")]
        [StringLength(10)]
        public string Job1 { get; set; }

        [StringLength(6)]
        public string Sales_Rep { get; set; }

        [StringLength(10)]
        public string Customer { get; set; }

        public int? Ship_To { get; set; }

        public int? User_Values { get; set; }

        [StringLength(10)]
        public string Quote { get; set; }

        public int? Contact { get; set; }

        [StringLength(15)]
        public string Ship_Via { get; set; }

        [StringLength(15)]
        public string Terms { get; set; }

        [StringLength(15)]
        public string Tax_Code { get; set; }

        [StringLength(15)]
        public string Sales_Code { get; set; }

        [StringLength(10)]
        public string Top_Lvl_Job { get; set; }

        [Required]
        [StringLength(8)]
        public string Type { get; set; }

        public DateTime Order_Date { get; set; }

        [Required]
        [StringLength(8)]
        public string Status { get; set; }

        public DateTime Status_Date { get; set; }

        [StringLength(30)]
        public string Part_Number { get; set; }

        [StringLength(10)]
        public string Rev { get; set; }

        [StringLength(30)]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string Ext_Description { get; set; }

        [StringLength(30)]
        public string Drawing { get; set; }

        public bool Build_To_Stock { get; set; }

        public int Order_Quantity { get; set; }

        public int? Extra_Quantity { get; set; }

        public int? Pick_Quantity { get; set; }

        public int Make_Quantity { get; set; }

        public int? Split_Quantity { get; set; }

        public int? Completed_Quantity { get; set; }

        public int? Shipped_Quantity { get; set; }

        public int? FG_Transfer_Qty { get; set; }

        public int? Returned_Quantity { get; set; }

        public int In_Production_Quantity { get; set; }

        public short? Assembly_Level { get; set; }

        public bool Certs_Required { get; set; }

        public bool Time_And_Materials { get; set; }

        public short? Open_Operations { get; set; }

        public double Scrap_Pct { get; set; }

        public int? Est_Scrap_Qty { get; set; }

        public double? Est_Rem_Hrs { get; set; }

        public double? Est_Total_Hrs { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Material { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Service { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Est_GA_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Revenue { get; set; }

        public int? Act_Scrap_Quantity { get; set; }

        public double? Act_Total_Hrs { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Labor { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Material { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Service { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Act_GA_Burden { get; set; }

        public short? Priority { get; set; }

        public double? Unit_Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total_Price { get; set; }

        [StringLength(4)]
        public string Price_UofM { get; set; }

        public double Currency_Conv_Rate { get; set; }

        public int? Trade_Currency { get; set; }

        public bool Fixed_Rate { get; set; }

        public DateTime? Trade_Date { get; set; }

        public double? Commission_Pct { get; set; }

        [StringLength(20)]
        public string Customer_PO { get; set; }

        [StringLength(6)]
        public string Customer_PO_LN { get; set; }

        public DateTime? Sched_End { get; set; }

        public DateTime? Sched_Start { get; set; }

        public double? Quantity_Per { get; set; }

        public double? Profit_Pct { get; set; }

        public double Labor_Markup_Pct { get; set; }

        public double Mat_Markup_Pct { get; set; }

        public double Serv_Markup_Pct { get; set; }

        public double Labor_Burden_Markup_Pct { get; set; }

        public double Machine_Burden_Markup_Pct { get; set; }

        public double GA_Burden_Markup_Pct { get; set; }

        public short? Lead_Days { get; set; }

        [StringLength(1)]
        public string Profit_Markup { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prepaid_Amt { get; set; }

        public bool Split_To_Job { get; set; }

        [Column(TypeName = "text")]
        public string Note_Text { get; set; }

        [Column(TypeName = "text")]
        public string Comment { get; set; }

        public DateTime Last_Updated { get; set; }

        [StringLength(4)]
        public string Order_Unit { get; set; }

        public double? Price_Unit_Conv { get; set; }

        [StringLength(50)]
        public string Holder_ID { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        [StringLength(50)]
        public string Order_Taken_By { get; set; }

        public bool? Plan_Modified { get; set; }

        public Guid ObjectID { get; set; }

        public DateTime? Released_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prepaid_Tax_Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prepaid_Trade_Amt { get; set; }

        [StringLength(50)]
        public string Last_Updated_By { get; set; }

        public bool CommissionIncluded { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Req> Material_Req { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Operation> Job_Operation { get; set; }
    }
}
