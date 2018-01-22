namespace Models.ES 
{
	public class ServiceType
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string Name {get; set;} 
		public int RatingCoefficient {get; set;} 
		public int Available {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}