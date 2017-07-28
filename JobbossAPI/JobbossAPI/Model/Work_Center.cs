namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Work_Center
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Work_Center()
        {
            Employee = new HashSet<Employee>();
            Job_Operation = new HashSet<Job_Operation>();
        }

        [Key]
        [Column("Work_Center")]
        [StringLength(10)]
        public string Work_Center1 { get; set; }

        public int? User_Values_OLD { get; set; }

        [StringLength(15)]
        public string Department { get; set; }

        [Required]
        [StringLength(8)]
        public string Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? Setup_Labor_Rate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Run_Labor_Rate { get; set; }

        public double? Labor_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? Machine_Burden { get; set; }

        [Column(TypeName = "money")]
        public decimal? GA_Burden { get; set; }

        public double? Sched_Hrs_OLD { get; set; }

        public double? Queue_Hrs { get; set; }

        public short? Nbr_Limiting_Rsrc_OLD { get; set; }

        public double? Capacity_OLD { get; set; }

        public bool Link_Material { get; set; }

        public bool Link_Component { get; set; }

        [Column(TypeName = "text")]
        public string Note_Text { get; set; }

        public DateTime Last_Updated { get; set; }

        public bool? Is_Parent { get; set; }

        public bool? Has_Parent { get; set; }

        [StringLength(10)]
        public string Parent_ID { get; set; }

        public Guid ObjectID { get; set; }

        public int? Machines { get; set; }

        public int? Operators { get; set; }

        public double? Operators_Per_Machine { get; set; }

        public Guid? Parent_OID { get; set; }

        public bool? Link_FinishedGoods { get; set; }

        public bool? Link_Hardware { get; set; }

        public bool? Link_Supplies { get; set; }

        public bool? Link_Misc { get; set; }

        public bool? Link_RawStock { get; set; }

        public bool? Finite_Schedule { get; set; }

        public double? Lag_Hrs { get; set; }

        public DateTime? UVDate1 { get; set; }

        public DateTime? UVDate2 { get; set; }

        [StringLength(15)]
        public string UVText1 { get; set; }

        [StringLength(15)]
        public string UVText2 { get; set; }

        [StringLength(15)]
        public string UVText3 { get; set; }

        [StringLength(30)]
        public string UVText4 { get; set; }

        [StringLength(30)]
        public string UVText5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? UVAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? UVAmount2 { get; set; }

        public double? UVNumeric1 { get; set; }

        public double? UVNumeric2 { get; set; }

        public double? UVDecimal1 { get; set; }

        [Column(TypeName = "text")]
        public string UVNote_Text { get; set; }

        public bool? Equipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Operation> Job_Operation { get; set; }
    }
}
