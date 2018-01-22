namespace Models.ES 
{
	public class BillServiceDetail
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string BillServiceUid {get; set;} 
		public string ServiceUid {get; set;} 
		public int Quantity {get; set;} 
		public float Price {get; set;} 
		public float DiscountMoney {get; set;} 
		public float IncomeMoney {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}