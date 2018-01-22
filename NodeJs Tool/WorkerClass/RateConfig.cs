using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class RateConfig: TableInfo
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

		[Text(Name="score")]
		[JsonProperty("score")]
		public int? Score {get; set;}

		[Text(Name="object_uid")]
		[JsonProperty("object_uid")]
		public string ObjectUid {get; set;}

		public override string TableName() { return "rate_config"; }
		public static string GetIndexName() { return "db30shine_rating__rate_config"; }
}
}