using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class Service: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="service_type_uid")]
		[JsonProperty("service_type_uid")]
		public string ServiceTypeUid {get; set;}

		[Text(Name="name")]
		[JsonProperty("name")]
		public string Name {get; set;}

		[Text(Name="code")]
		[JsonProperty("code")]
		public string Code {get; set;}

		[Text(Name="description")]
		[JsonProperty("description")]
		public string Description {get; set;}

		[Text(Name="price")]
		[JsonProperty("price")]
		public float? Price {get; set;}

		[Text(Name="order_number")]
		[JsonProperty("order_number")]
		public int? OrderNumber {get; set;}

		[Text(Name="is_active")]
		[JsonProperty("is_active")]
		public int? IsActive {get; set;}

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

		public override string TableName() { return "service"; }
		public static string GetIndexName() { return "db30shine_service__service"; }
}
}