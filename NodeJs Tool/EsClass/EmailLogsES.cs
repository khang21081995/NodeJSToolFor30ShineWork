using Nest;

namespace API30Shine.Models.ESModels 
{
	public class EmailLogsES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public long Id {get; set;} 

		[Text(Name="object_type")]
		public string ObjectType {get; set;} 

		[Text(Name="object_uid")]
		public string ObjectUid {get; set;} 

		[Text(Name="sender")]
		public string Sender {get; set;} 

		[Text(Name="receiver")]
		public string Receiver {get; set;} 

		[Text(Name="body")]
		public string Body {get; set;} 

		[Text(Name="subject")]
		public string Subject {get; set;} 

		[Text(Name="send_time")]
		public long SendTime {get; set;} 

		[Text(Name="created_at")]
		public DateTime CreatedAt {get; set;} 

		[Text(Name="updated_at")]
		public DateTime UpdatedAt {get; set;} 

	}
}