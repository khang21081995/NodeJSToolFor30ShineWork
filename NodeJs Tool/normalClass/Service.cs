namespace Models.ES 
{
	public class Service
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string ServiceTypeUid {get; set;} 
		public string Name {get; set;} 
		public string Code {get; set;} 
		public string Description {get; set;} 
		public float Price {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}