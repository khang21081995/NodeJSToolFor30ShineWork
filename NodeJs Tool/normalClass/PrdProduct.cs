namespace Models.ES 
{
	public class PrdProduct
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string BrandUid {get; set;} 
		public string Code {get; set;} 
		public string Name {get; set;} 
		public string Description {get; set;} 
		public float Cost {get; set;} 
		public float Price {get; set;} 
		public int IsCombo {get; set;} 
		public float PriceCombo {get; set;} 
		public float PercentForSalary {get; set;} 
		public string Volume {get; set;} 
		public int IsHcInventory {get; set;} 
		public int IsMaterial {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 

}
}