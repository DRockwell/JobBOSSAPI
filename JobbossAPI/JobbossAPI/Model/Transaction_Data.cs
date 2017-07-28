namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction_Data
    {
        [Key]
        [Column("Transaction_Data")]
        [StringLength(50)]
        public string Transaction_Data1 { get; set; }

        public int? Transaction_Type { get; set; }

        [StringLength(6)]
        public string Employee { get; set; }

        public DateTime? Work_Date { get; set; }

        [StringLength(50)]
        public string Terminal_ID { get; set; }

        public int? Status { get; set; }

        public DateTime? Transaction_Start { get; set; }

        public DateTime? Transaction_End { get; set; }

        [StringLength(50)]
        public string Error_ID { get; set; }

        [StringLength(255)]
        public string Error_Text { get; set; }

        public int? Linked_Tran_Int { get; set; }

        [StringLength(50)]
        public string Linked_Tran_String { get; set; }

        public int? Target_Int { get; set; }

        [StringLength(50)]
        public string Target_String { get; set; }

        [StringLength(10)]
        public string Job { get; set; }

        [StringLength(30)]
        public string Material { get; set; }

        public double? Quantity { get; set; }

        [StringLength(15)]
        public string Document { get; set; }

        [StringLength(10)]
        public string Location { get; set; }

        [StringLength(10)]
        public string Location_1 { get; set; }

        [StringLength(20)]
        public string Lot { get; set; }

        [StringLength(20)]
        public string Lot_1 { get; set; }

        [StringLength(8)]
        public string PO { get; set; }

        [StringLength(6)]
        public string PO_Line { get; set; }

        public DateTime? Last_Updated { get; set; }

        public bool? Close { get; set; }
    }
}
