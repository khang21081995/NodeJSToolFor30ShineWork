namespace Models.ES 
{
	public class UsrResourceAccess
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string RoleUid {get; set;} 
		public string ScopeUid {get; set;} 
		public string PermUid {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}