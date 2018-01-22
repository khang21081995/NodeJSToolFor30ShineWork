namespace Models.ES 
{
	public class SalaryStaff
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string StaffUid {get; set;} 
		public string SalonUid {get; set;} 
		public float FixSalary {get; set;} 
		public float AllowanceSalary {get; set;} 
		public float OvertimeSalary {get; set;} 
		public float ServiceSalary {get; set;} 
		public float ProductSalary {get; set;} 
		public int WorkDay {get; set;} 
		public float RatingPoint {get; set;} 
		public int BillNormal {get; set;} 
		public int BillNormalGreat {get; set;} 
		public int BillNormalGood {get; set;} 
		public int BillNormalBad {get; set;} 
		public int BillNormalNorating {get; set;} 
		public int BillSpecial {get; set;} 
		public int BillSpecialGreat {get; set;} 
		public int BillSpecialGood {get; set;} 
		public int BillSpecialBad {get; set;} 
		public int BillSpecialNorating {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}