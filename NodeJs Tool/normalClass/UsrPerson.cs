namespace Models.ES 
{
	public class UsrPerson
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string CityUid {get; set;} 
		public string DistrictUid {get; set;} 
		public string FullName {get; set;} 
		public string FirstName {get; set;} 
		public string LastName {get; set;} 
		public int Dob {get; set;} 
		public int Gender {get; set;} 
		public string PhoneNumber {get; set;} 
		public string Email {get; set;} 
		public string Address {get; set;} 
		public string AvartarUrl {get; set;} 
		public string FbUrl {get; set;} 
		public string GoogleUrl {get; set;} 
		public string FbChatbotId {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}