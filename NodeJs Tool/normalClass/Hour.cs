namespace Models.ES 
{
	public class Hour
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string HourFrame {get; set;} 
		public string HourTime {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}