namespace Models.ES 
{
	public class PushLogs
{
			public int Id {get; set;} 
		public string ObjectType {get; set;} 
		public string ObjectUid {get; set;} 
		public string MessageId {get; set;} 
		public string Target {get; set;} 
		public string Arn {get; set;} 
		public int PublishTime {get; set;} 
		public string Message {get; set;} 
		public string Pushid {get; set;} 
		public int Status {get; set;} 
		public DateTime CreatedAt {get; set;} 
		public DateTime UpdatedAt {get; set;} 

}
}