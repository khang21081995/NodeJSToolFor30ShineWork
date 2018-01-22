using Nest;

namespace API30Shine.Models.ESModels 
{
	public class PushLogsES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="object_type")]
		public string ObjectType {get; set;} 

		[Text(Name="object_uid")]
		public string ObjectUid {get; set;} 

		[Text(Name="message_id")]
		public string MessageId {get; set;} 

		[Text(Name="target")]
		public string Target {get; set;} 

		[Text(Name="arn")]
		public string Arn {get; set;} 

		[Text(Name="publish_time")]
		public int PublishTime {get; set;} 

		[Text(Name="message")]
		public string Message {get; set;} 

		[Text(Name="pushid")]
		public string Pushid {get; set;} 

		[Text(Name="status")]
		public int Status {get; set;} 

		[Text(Name="created_at")]
		public DateTime CreatedAt {get; set;} 

		[Text(Name="updated_at")]
		public DateTime UpdatedAt {get; set;} 

	}
}