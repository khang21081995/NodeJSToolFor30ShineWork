namespace Models.ES 
{
	public class TimeKeeping
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string StaffUid {get; set;} 
		public string TimeKeeperUid {get; set;} 
		public string SalonUid {get; set;} 
		public string WorkingShiftUid {get; set;} 
		public int WorkDate {get; set;} 
		public float WorkHour {get; set;} 
		public int IsEnroll {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public string Note {get; set;} 

}
}