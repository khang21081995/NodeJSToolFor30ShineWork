using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class BillProduct: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="customer_uid")]
		[JsonProperty("customer_uid")]
		public string CustomerUid {get; set;}

		[Text(Name="seller_uid")]
		[JsonProperty("seller_uid")]
		public string SellerUid {get; set;}

		[Text(Name="total_discount_money")]
		[JsonProperty("total_discount_money")]
		public float? TotalDiscountMoney {get; set;}

		[Text(Name="total_income_money")]
		[JsonProperty("total_income_money")]
		public float? TotalIncomeMoney {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public long? CreateTime {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public long? ModifyTime {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		public override string TableName() { return "bill_product"; }
		public static string GetIndexName() { return "db30shine_bill__bill_product"; }
}
}