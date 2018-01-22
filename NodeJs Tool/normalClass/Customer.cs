namespace Models.ES 
{
	public class Customer
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string UserUid {get; set;} 
		public string SalonUid {get; set;} 
		public string ThreadUid {get; set;} 
		public int TotalPoint {get; set;} 
		public int TotalBill {get; set;} 
		public float TotalMoney {get; set;} 
		public int IsOld {get; set;} 
		public int IsVerify {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}