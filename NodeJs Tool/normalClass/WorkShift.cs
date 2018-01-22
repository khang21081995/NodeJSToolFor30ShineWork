namespace Models.ES 
{
	public class WorkShift
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string Name {get; set;} 
		public string StartTime {get; set;} 
		public string EndTime {get; set;} 
		public string LunchHour {get; set;} 
		public string LunchHour2 {get; set;} 
		public string Color {get; set;} 
		public int TotalHourFrame {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}