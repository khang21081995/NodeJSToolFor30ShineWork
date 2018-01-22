namespace Models.ES 
{
	public class UsrUserRole
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string UserUid {get; set;} 
		public string RoleUid {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}