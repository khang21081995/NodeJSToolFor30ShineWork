namespace Models.ES 
{
	public class PrdBrand
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string Name {get; set;} 
		public string Description {get; set;} 
		public string Origin {get; set;} 
		public string Images {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 

}
}