namespace Models.ES 
{
	public class SalaryConfig
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string StaffDepartmentUid {get; set;} 
		public string StaffLevelUid {get; set;} 
		public string StaffTypeUid {get; set;} 
		public string Description {get; set;} 
		public float FixSalary {get; set;} 
		public float OvertimeSalary {get; set;} 
		public float Allowance {get; set;} 
		public float RatingCoefficientMoney {get; set;} 
		public float ProductBonus {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}