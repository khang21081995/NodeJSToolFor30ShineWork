namespace Models.ES 
{
	public class BookingSlot
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string SalonUid {get; set;} 
		public int WorkDate {get; set;} 
		public int Slot {get; set;} 
		public int TotalSlot {get; set;} 
		public float PercentSlot {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}