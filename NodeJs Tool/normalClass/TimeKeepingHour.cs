namespace Models.ES 
{
	public class TimeKeepingHour
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string TimeKeepingUid {get; set;} 
		public string HourUid {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}