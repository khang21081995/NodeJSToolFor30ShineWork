using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class ServiceType: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="name")]
		[JsonProperty("name")]
		public string Name {get; set;}

		[Text(Name="rating_coefficient")]
		[JsonProperty("rating_coefficient")]
		public int? RatingCoefficient {get; set;}

		[Text(Name="available")]
		[JsonProperty("available")]
		public int? Available {get; set;}

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

		public override string TableName() { return "service_type"; }
		public static string GetIndexName() { return "db30shine_service__service_type"; }
}
}