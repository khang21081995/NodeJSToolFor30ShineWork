namespace Models.ES 
{
	public class RatingConfig
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public int RealPoint {get; set;} 
		public int ConventionPoint {get; set;} 
		public string ConventionName {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}