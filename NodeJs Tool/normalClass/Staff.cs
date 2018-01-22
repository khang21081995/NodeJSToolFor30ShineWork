namespace Models.ES 
{
	public class Staff
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string UserUid {get; set;} 
		public string SalonUid {get; set;} 
		public string RoleUid {get; set;} 
		public string StaffDepartmentUid {get; set;} 
		public string StaffLevelUid {get; set;} 
		public string StaffTypeUid {get; set;} 
		public int IsRequireEnroll {get; set;} 
		public string BankAccNumber {get; set;} 
		public string BankAccOwner {get; set;} 
		public string BankBranch {get; set;} 
		public string BankName {get; set;} 
		public string Images {get; set;} 
		public string InsurranceNumber {get; set;} 
		public int JoinTime {get; set;} 
		public int SeniorityTime {get; set;} 
		public int LevelPoint {get; set;} 
		public int AvgCutTime {get; set;} 
		public string CardIdNumber {get; set;} 
		public string CardIdName {get; set;} 
		public string CardIdImgFront {get; set;} 
		public string CardIdImgBack {get; set;} 
		public string About {get; set;} 
		public string Note {get; set;} 
		public string TaxNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}