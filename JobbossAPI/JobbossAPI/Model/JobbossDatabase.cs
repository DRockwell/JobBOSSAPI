namespace JobbossAPI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JobbossDatabase : DbContext
    {
        public JobbossDatabase(string ConnectionString)
            : base(ConnectionString)
        {
        }

        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Breaks> Breaks { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Job_Operation> Job_Operation { get; set; }
        public virtual DbSet<Job_Operation_Time> Job_Operation_Time { get; set; }
        public virtual DbSet<Material_Req> Material_Req { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Shift_Day> Shift_Day { get; set; }
        public virtual DbSet<Transaction_Data> Transaction_Data { get; set; }
        public virtual DbSet<Transaction_Detail> Transaction_Detail { get; set; }
        public virtual DbSet<User_Code> User_Code { get; set; }
        public virtual DbSet<Work_Center> Work_Center { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .Property(e => e.Attendance1)
                .IsUnicode(false);

            modelBuilder.Entity<Attendance>()
                .Property(e => e.Employee)
                .IsUnicode(false);

            modelBuilder.Entity<Breaks>()
                .Property(e => e.Break_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Employee1)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Work_Center)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Middle_Initial)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Hourly_Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Note_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Begin_Tran_Prompt)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Repeat_Tran_Prompt)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Job)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.Sales_Rep);

            modelBuilder.Entity<Job>()
                .Property(e => e.Job1)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Sales_Rep)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Quote)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Ship_Via)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Terms)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Tax_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Sales_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Top_Lvl_Job)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Part_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Rev)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Ext_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Drawing)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Est_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Est_Material)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Est_Service)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Est_Labor_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Est_Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Est_GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_Revenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_Material)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_Service)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_Labor_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Act_GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Total_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Price_UofM)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Customer_PO)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Customer_PO_LN)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Profit_Markup)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Prepaid_Amt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Note_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Order_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Holder_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Order_Taken_By)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Prepaid_Tax_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Prepaid_Trade_Amt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .Property(e => e.Last_Updated_By)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Material_Req)
                .WithRequired(e => e.Job1)
                .HasForeignKey(e => e.Job);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Job_Operation)
                .WithRequired(e => e.Job1)
                .HasForeignKey(e => e.Job);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Vendor)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Work_Center)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Operation_Service)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.WC_Vendor)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Run_Method)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_Setup_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_Run_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_Labor_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_Addl_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Est_Total_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_Setup_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_Run_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_Labor_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_Addl_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Addl_Cost_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Act_Total_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Overlap_Method)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Minimum_Chg_Amt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Cost_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Rwk_Setup_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Rwk_Run_Labor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Rwk_Labor_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Rwk_Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Rwk_GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Note_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Holder_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Op_Group)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Floor_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.SB_RunMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation>()
                .Property(e => e.Last_Updated_By)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Employee)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Note_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Job_Operation_Time1)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Scrap_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Rwk_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.WC)
                .IsUnicode(false);

            modelBuilder.Entity<Job_Operation_Time>()
                .Property(e => e.Op_Group)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Vendor)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Pick_Buy_Indicator)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Quantity_Per_Basis)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.UofM)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Est_Addl_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Est_Total_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Addl_Cost_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Act_Addl_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Act_Total_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Vendor_Reference)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Note_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Holder_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Cost_UofM)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Drawing_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Req>()
                .Property(e => e.Res_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .Property(e => e.Shift_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Transaction_Data1)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Employee)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Terminal_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Error_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Error_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Linked_Tran_String)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Target_String)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Document)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Location_1)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Lot)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.Lot_1)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.PO)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Data>()
                .Property(e => e.PO_Line)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Transaction_Data)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Rework_Rsn)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Scrap_Rsn)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Work_Center)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Linked_Tran_String)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Text1)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.Text4)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction_Detail>()
                .Property(e => e.PartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<User_Code>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<User_Code>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<User_Code>()
                .Property(e => e.Text1)
                .IsUnicode(false);

            modelBuilder.Entity<User_Code>()
                .Property(e => e.Text2)
                .IsUnicode(false);

            modelBuilder.Entity<User_Code>()
                .Property(e => e.Text3)
                .IsUnicode(false);

            modelBuilder.Entity<User_Code>()
                .Property(e => e.Text4)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Work_Center1)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Setup_Labor_Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Run_Labor_Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Machine_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.GA_Burden)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Note_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.Parent_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVText1)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVText2)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVText3)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVText4)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVText5)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Work_Center>()
                .Property(e => e.UVNote_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Work_Center>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Work_Center1)
                .HasForeignKey(e => e.Work_Center);

            modelBuilder.Entity<Work_Center>()
                .HasMany(e => e.Job_Operation)
                .WithOptional(e => e.Work_Center1)
                .HasForeignKey(e => e.Work_Center);
        }
    }
}
