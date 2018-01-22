using Nest;

namespace API30Shine.Models.ESModels 
{
	public class BillProductES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="customer_uid")]
		public string CustomerUid {get; set;} 

		[Text(Name="seller_uid")]
		public string SellerUid {get; set;} 

		[Text(Name="total_discount_money")]
		public float TotalDiscountMoney {get; set;} 

		[Text(Name="total_income_money")]
		public float TotalIncomeMoney {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="create_time")]
		public long CreateTime {get; set;} 

		[Text(Name="modify_time")]
		public long ModifyTime {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

	}
}