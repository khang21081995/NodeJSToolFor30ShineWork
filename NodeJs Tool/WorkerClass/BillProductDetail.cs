using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class BillProductDetail: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="bill_product_uid")]
		[JsonProperty("bill_product_uid")]
		public string BillProductUid {get; set;}

		[Text(Name="prd_product_uid")]
		[JsonProperty("prd_product_uid")]
		public string PrdProductUid {get; set;}

		[Text(Name="prd_group_uid")]
		[JsonProperty("prd_group_uid")]
		public string PrdGroupUid {get; set;}

		[Text(Name="quantity")]
		[JsonProperty("quantity")]
		public int? Quantity {get; set;}

		[Text(Name="cost")]
		[JsonProperty("cost")]
		public float? Cost {get; set;}

		[Text(Name="price")]
		[JsonProperty("price")]
		public float? Price {get; set;}

		[Text(Name="discount_money")]
		[JsonProperty("discount_money")]
		public float? DiscountMoney {get; set;}

		[Text(Name="income_money")]
		[JsonProperty("income_money")]
		public float? IncomeMoney {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public int? CreateTime {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public int? ModifyTime {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		public override string TableName() { return "bill_product_detail"; }
		public static string GetIndexName() { return "db30shine_bill__bill_product_detail"; }
}
}