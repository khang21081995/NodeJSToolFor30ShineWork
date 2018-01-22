using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class RateRating: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="object_uid")]
		[JsonProperty("object_uid")]
		public string ObjectUid {get; set;}

		[Text(Name="instance_uid")]
		[JsonProperty("instance_uid")]
		public string InstanceUid {get; set;}

		[Text(Name="score")]
		[JsonProperty("score")]
		public int? Score {get; set;}

		public override string TableName() { return "rate_rating"; }
		public static string GetIndexName() { return "db30shine_rating__rate_rating"; }
}
}