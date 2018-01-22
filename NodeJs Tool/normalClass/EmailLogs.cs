namespace Models.ES 
{
	public class EmailLogs
{
			public long Id {get; set;} 
		public string ObjectType {get; set;} 
		public string ObjectUid {get; set;} 
		public string Sender {get; set;} 
		public string Receiver {get; set;} 
		public string Body {get; set;} 
		public string Subject {get; set;} 
		public long SendTime {get; set;} 
		public DateTime CreatedAt {get; set;} 
		public DateTime UpdatedAt {get; set;} 

}
}