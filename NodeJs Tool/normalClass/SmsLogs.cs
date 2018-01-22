namespace Models.ES 
{
	public class SmsLogs
{
			public long Id {get; set;} 
		public string ObjectType {get; set;} 
		public string ObjectUid {get; set;} 
		public string Phone {get; set;} 
		public string Message {get; set;} 
		public long SendTime {get; set;} 
		public int Status {get; set;} 
		public string Response {get; set;} 
		public DateTime CreatedAt {get; set;} 
		public DateTime UpdatedAt {get; set;} 

}
}