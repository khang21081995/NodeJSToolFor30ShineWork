using Nest;

namespace API30Shine.Models.ESModels 
{
	public class BillES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="customer_uid")]
		public string CustomerUid {get; set;} 

		[Text(Name="bill_product_uid")]
		public string BillProductUid {get; set;} 

		[Text(Name="bill_service_uid")]
		public string BillServiceUid {get; set;} 

		[Text(Name="salon_uid")]
		public string SalonUid {get; set;} 

		[Text(Name="voucher_uid")]
		public string VoucherUid {get; set;} 

		[Text(Name="check_out_uid")]
		public string CheckOutUid {get; set;} 

		[Text(Name="check_out_time")]
		public long CheckOutTime {get; set;} 

		[Text(Name="payment_method")]
		public string PaymentMethod {get; set;} 

		[Text(Name="bill_code")]
		public string BillCode {get; set;} 

		[Text(Name="pdf_code")]
		public string PdfCode {get; set;} 

		[Text(Name="time_use_service")]
		public int TimeUseService {get; set;} 

		[Text(Name="total_discount_money")]
		public float TotalDiscountMoney {get; set;} 

		[Text(Name="total_income_money")]
		public float TotalIncomeMoney {get; set;} 

		[Text(Name="is_calculate_salary")]
		public int IsCalculateSalary {get; set;} 

		[Text(Name="is_customer_familiar")]
		public int IsCustomerFamiliar {get; set;} 

		[Text(Name="is_error")]
		public int IsError {get; set;} 

		[Text(Name="error_note")]
		public string ErrorNote {get; set;} 

		[Text(Name="note")]
		public string Note {get; set;} 

		[Text(Name="is_pending")]
		public int IsPending {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="create_time")]
		public int CreateTime {get; set;} 

		[Text(Name="modify_time")]
		public int ModifyTime {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

	}
}