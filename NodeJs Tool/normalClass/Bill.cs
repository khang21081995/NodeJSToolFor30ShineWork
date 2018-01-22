namespace Models.ES 
{
	public class Bill
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string CustomerUid {get; set;} 
		public string BillProductUid {get; set;} 
		public string BillServiceUid {get; set;} 
		public string SalonUid {get; set;} 
		public string VoucherUid {get; set;} 
		public string CheckOutUid {get; set;} 
		public long CheckOutTime {get; set;} 
		public string PaymentMethod {get; set;} 
		public string BillCode {get; set;} 
		public string PdfCode {get; set;} 
		public int TimeUseService {get; set;} 
		public float TotalDiscountMoney {get; set;} 
		public float TotalIncomeMoney {get; set;} 
		public int IsCalculateSalary {get; set;} 
		public int IsCustomerFamiliar {get; set;} 
		public int IsError {get; set;} 
		public string ErrorNote {get; set;} 
		public string Note {get; set;} 
		public int IsPending {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}