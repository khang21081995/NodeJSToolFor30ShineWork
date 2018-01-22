using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class PrdProductGroup: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="prd_group_uid")]
		[JsonProperty("prd_group_uid")]
		public string PrdGroupUid {get; set;}

		[Text(Name="prd_product_uid")]
		[JsonProperty("prd_product_uid")]
		public string PrdProductUid {get; set;}

		[Text(Name="order_number")]
		[JsonProperty("order_number")]
		public int? OrderNumber {get; set;}

		[Text(Name="is_active")]
		[JsonProperty("is_active")]
		public int? IsActive {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public int? CreateTime {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public int? ModifyTime {get; set;}

		public override string TableName() { return "prd_product_group"; }
		public static string GetIndexName() { return "db30shine_product__prd_product_group"; }
}
}