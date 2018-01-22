using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class SmsLogs: TableInfo
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

		[Text(Name="phone")]
		[JsonProperty("phone")]
		public string Phone {get; set;}

		[Text(Name="message")]
		[JsonProperty("message")]
		public string Message {get; set;}

		[Text(Name="send_time")]
		[JsonProperty("send_time")]
		public long? SendTime {get; set;}

		[Text(Name="status")]
		[JsonProperty("status")]
		public int? Status {get; set;}

		[Text(Name="response")]
		[JsonProperty("response")]
		public string Response {get; set;}

		[Text(Name="created_at")]
		[JsonProperty("created_at")]
		public DateTime? CreatedAt {get; set;}

		[Text(Name="updated_at")]
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt {get; set;}

		public override string TableName() { return "sms_logs"; }
		public static string GetIndexName() { return "db30shine_notification__sms_logs"; }
}
}