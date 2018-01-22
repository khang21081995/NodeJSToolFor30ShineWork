using Nest;

namespace API30Shine.Models.ESModels 
{
	public class UsrPersonES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="city_uid")]
		public string CityUid {get; set;} 

		[Text(Name="district_uid")]
		public string DistrictUid {get; set;} 

		[Text(Name="full_name")]
		public string FullName {get; set;} 

		[Text(Name="first_name")]
		public string FirstName {get; set;} 

		[Text(Name="last_name")]
		public string LastName {get; set;} 

		[Text(Name="dob")]
		public int Dob {get; set;} 

		[Text(Name="gender")]
		public int Gender {get; set;} 

		[Text(Name="phone_number")]
		public string PhoneNumber {get; set;} 

		[Text(Name="email")]
		public string Email {get; set;} 

		[Text(Name="address")]
		public string Address {get; set;} 

		[Text(Name="avartar_url")]
		public string AvartarUrl {get; set;} 

		[Text(Name="fb_url")]
		public string FbUrl {get; set;} 

		[Text(Name="google_url")]
		public string GoogleUrl {get; set;} 

		[Text(Name="fb_chatbot_id")]
		public string FbChatbotId {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="create_time")]
		public int CreateTime {get; set;} 

		[Text(Name="modify_time")]
		public int ModifyTime {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

	}
}