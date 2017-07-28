namespace JobbossAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Job = new HashSet<Job>();
        }

        [Key]
        [Column("Employee")]
        [StringLength(6)]
        public string Employee1 { get; set; }

        [StringLength(10)]
        public string Work_Center { get; set; }

        public int? Address { get; set; }

        public int? User_Values { get; set; }

        [StringLength(10)]
        public string First_Name { get; set; }

        [StringLength(1)]
        public string Middle_Initial { get; set; }

        [StringLength(20)]
        public string Last_Name { get; set; }

        [StringLength(11)]
        public string SSN { get; set; }

        [Required]
        [StringLength(6)]
        public string Type { get; set; }

        [Required]
        [StringLength(8)]
        public string Status { get; set; }

        [Required]
        [StringLength(1)]
        public string Class { get; set; }

        [Column(TypeName = "money")]
        public decimal? Hourly_Rate { get; set; }

        public double? Commission_Pct { get; set; }

        public DateTime? Shift_Start { get; set; }

        public DateTime? Shift_End { get; set; }

        public DateTime? Hire_Date { get; set; }

        [Column(TypeName = "text")]
        public string Note_Text { get; set; }

        public DateTime Last_Updated { get; set; }

        public Guid? Shift { get; set; }

        [StringLength(15)]
        public string Department { get; set; }

        [StringLength(6)]
        public string Supervisor { get; set; }

        public short? Default_Tran_Limit { get; set; }

        [StringLength(15)]
        public string Begin_Tran_Prompt { get; set; }

        [StringLength(15)]
        public string Repeat_Tran_Prompt { get; set; }

        public bool? Tran_Repeater { get; set; }

        public Guid ObjectID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Job { get; set; }

        public virtual Work_Center Work_Center1 { get; set; }
    }
}
