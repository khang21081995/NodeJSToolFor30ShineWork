namespace Models.ES 
{
	public class SalonService
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string SalonUid {get; set;} 
		public string ServiceUid {get; set;} 
		public int IsCheck {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}