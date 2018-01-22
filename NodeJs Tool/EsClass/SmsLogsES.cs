using Nest;

namespace API30Shine.Models.ESModels 
{
	public class SmsLogsES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public long Id {get; set;} 

		[Text(Name="object_type")]
		public string ObjectType {get; set;} 

		[Text(Name="object_uid")]
		public string ObjectUid {get; set;} 

		[Text(Name="phone")]
		public string Phone {get; set;} 

		[Text(Name="message")]
		public string Message {get; set;} 

		[Text(Name="send_time")]
		public long SendTime {get; set;} 

		[Text(Name="status")]
		public int Status {get; set;} 

		[Text(Name="response")]
		public string Response {get; set;} 

		[Text(Name="created_at")]
		public DateTime CreatedAt {get; set;} 

		[Text(Name="updated_at")]
		public DateTime UpdatedAt {get; set;} 

	}
}