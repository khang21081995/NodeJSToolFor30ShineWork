using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class PrdProduct: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="brand_uid")]
		[JsonProperty("brand_uid")]
		public string BrandUid {get; set;}

		[Text(Name="code")]
		[JsonProperty("code")]
		public string Code {get; set;}

		[Text(Name="name")]
		[JsonProperty("name")]
		public string Name {get; set;}

		[Text(Name="description")]
		[JsonProperty("description")]
		public string Description {get; set;}

		[Text(Name="cost")]
		[JsonProperty("cost")]
		public float? Cost {get; set;}

		[Text(Name="price")]
		[JsonProperty("price")]
		public float? Price {get; set;}

		[Text(Name="is_combo")]
		[JsonProperty("is_combo")]
		public int? IsCombo {get; set;}

		[Text(Name="price_combo")]
		[JsonProperty("price_combo")]
		public float? PriceCombo {get; set;}

		[Text(Name="percent_for_salary")]
		[JsonProperty("percent_for_salary")]
		public float? PercentForSalary {get; set;}

		[Text(Name="volume")]
		[JsonProperty("volume")]
		public string Volume {get; set;}

		[Text(Name="is_hc_inventory")]
		[JsonProperty("is_hc_inventory")]
		public int? IsHcInventory {get; set;}

		[Text(Name="is_material")]
		[JsonProperty("is_material")]
		public int? IsMaterial {get; set;}

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

		public override string TableName() { return "prd_product"; }
		public static string GetIndexName() { return "db30shine_product__prd_product"; }
}
}