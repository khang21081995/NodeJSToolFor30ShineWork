namespace Models.ES 
{
	public class PrdProductGroup
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string PrdGroupUid {get; set;} 
		public string PrdProductUid {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 

}
}