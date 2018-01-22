namespace Models.ES 
{
	public class UsrUser
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string PersonUid {get; set;} 
		public string Account {get; set;} 
		public string Password {get; set;} 
		public int LastLoginTime {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}