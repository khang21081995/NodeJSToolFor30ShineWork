using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class PushLogs: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="object_type")]
		[JsonProperty("object_type")]
		public string ObjectType {get; set;}

		[Text(Name="object_uid")]
		[JsonProperty("object_uid")]
		public string ObjectUid {get; set;}

		[Text(Name="message_id")]
		[JsonProperty("message_id")]
		public string MessageId {get; set;}

		[Text(Name="target")]
		[JsonProperty("target")]
		public string Target {get; set;}

		[Text(Name="arn")]
		[JsonProperty("arn")]
		public string Arn {get; set;}

		[Text(Name="publish_time")]
		[JsonProperty("publish_time")]
		public int? PublishTime {get; set;}

		[Text(Name="message")]
		[JsonProperty("message")]
		public string Message {get; set;}

		[Text(Name="pushid")]
		[JsonProperty("pushid")]
		public string Pushid {get; set;}

		[Text(Name="status")]
		[JsonProperty("status")]
		public int? Status {get; set;}

		[Text(Name="created_at")]
		[JsonProperty("created_at")]
		public DateTime? CreatedAt {get; set;}

		[Text(Name="updated_at")]
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt {get; set;}

		public override string TableName() { return "push_logs"; }
		public static string GetIndexName() { return "db30shine_notification__push_logs"; }
}
}