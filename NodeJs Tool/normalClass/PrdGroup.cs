namespace Models.ES 
{
	public class PrdGroup
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string ParentUid {get; set;} 
		public string GroupTypeUid {get; set;} 
		public string Name {get; set;} 
		public string Description {get; set;} 
		public string ThumbImages {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public string TmpProductUid {get; set;} 

}
}