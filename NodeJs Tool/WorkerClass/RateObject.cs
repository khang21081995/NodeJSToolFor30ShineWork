using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class RateObject: TableInfo
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

		[Text(Name="default_score")]
		[JsonProperty("default_score")]
		public int? DefaultScore {get; set;}

		public override string TableName() { return "rate_object"; }
		public static string GetIndexName() { return "db30shine_rating__rate_object"; }
}
}