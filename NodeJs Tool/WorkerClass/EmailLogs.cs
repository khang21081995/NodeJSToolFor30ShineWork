using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class EmailLogs: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public long? Id {get; set;}

		[Text(Name="object_type")]
		[JsonProperty("object_type")]
		public string ObjectType {get; set;}

		[Text(Name="object_uid")]
		[JsonProperty("object_uid")]
		public string ObjectUid {get; set;}

		[Text(Name="sender")]
		[JsonProperty("sender")]
		public string Sender {get; set;}

		[Text(Name="receiver")]
		[JsonProperty("receiver")]
		public string Receiver {get; set;}

		[Text(Name="body")]
		[JsonProperty("body")]
		public string Body {get; set;}

		[Text(Name="subject")]
		[JsonProperty("subject")]
		public string Subject {get; set;}

		[Text(Name="send_time")]
		[JsonProperty("send_time")]
		public long? SendTime {get; set;}

		[Text(Name="created_at")]
		[JsonProperty("created_at")]
		public DateTime? CreatedAt {get; set;}

		[Text(Name="updated_at")]
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt {get; set;}

		public override string TableName() { return "email_logs"; }
		public static string GetIndexName() { return "db30shine_notification__email_logs"; }
}
}