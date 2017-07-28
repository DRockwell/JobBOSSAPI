namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction_Detail
    {
        [Key]
        [Column("Transaction_Detail")]
        public int Transaction_Detail1 { get; set; }

        [StringLength(50)]
        public string Transaction_Data { get; set; }

        public int? Target_Integer { get; set; }

        public double? Labor_Hrs { get; set; }

        public double? Machine_Hrs { get; set; }

        public double? Percent_Complete { get; set; }

        public int? Entry_Type { get; set; }

        public bool? Rework { get; set; }

        [StringLength(15)]
        public string Rework_Rsn { get; set; }

        [StringLength(15)]
        public string Scrap_Rsn { get; set; }

        public int? Scrap_Qty { get; set; }

        [Column(TypeName = "text")]
        public string Notes { get; set; }

        public bool? Complete_Operation { get; set; }

        public int? Quantity { get; set; }

        [StringLength(10)]
        public string Work_Center { get; set; }

        [StringLength(10)]
        public string Job { get; set; }

        [StringLength(10)]
        public string Operation { get; set; }

        [StringLength(50)]
        public string Linked_Tran_String { get; set; }

        [StringLength(15)]
        public string Text1 { get; set; }

        [StringLength(25)]
        public string Text4 { get; set; }

        public Guid? SN_OID { get; set; }

        [StringLength(25)]
        public string SerialNumber { get; set; }

        [StringLength(30)]
        public string PartNumber { get; set; }

        public double? CurrentUsage { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool SN_IsScrapped { get; set; }
    }
}
