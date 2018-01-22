namespace Models.ES 
{
	public class BillProduct
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string CustomerUid {get; set;} 
		public string SellerUid {get; set;} 
		public float TotalDiscountMoney {get; set;} 
		public float TotalIncomeMoney {get; set;} 
		public int IsDelete {get; set;} 
		public long CreateTime {get; set;} 
		public long ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}