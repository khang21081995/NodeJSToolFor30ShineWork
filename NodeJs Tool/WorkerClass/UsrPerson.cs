using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class UsrPerson: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="city_uid")]
		[JsonProperty("city_uid")]
		public string CityUid {get; set;}

		[Text(Name="district_uid")]
		[JsonProperty("district_uid")]
		public string DistrictUid {get; set;}

		[Text(Name="full_name")]
		[JsonProperty("full_name")]
		public string FullName {get; set;}

		[Text(Name="first_name")]
		[JsonProperty("first_name")]
		public string FirstName {get; set;}

		[Text(Name="last_name")]
		[JsonProperty("last_name")]
		public string LastName {get; set;}

		[Text(Name="dob")]
		[JsonProperty("dob")]
		public int? Dob {get; set;}

		[Text(Name="gender")]
		[JsonProperty("gender")]
		public int? Gender {get; set;}

		[Text(Name="phone_number")]
		[JsonProperty("phone_number")]
		public string PhoneNumber {get; set;}

		[Text(Name="email")]
		[JsonProperty("email")]
		public string Email {get; set;}

		[Text(Name="address")]
		[JsonProperty("address")]
		public string Address {get; set;}

		[Text(Name="avartar_url")]
		[JsonProperty("avartar_url")]
		public string AvartarUrl {get; set;}

		[Text(Name="fb_url")]
		[JsonProperty("fb_url")]
		public string FbUrl {get; set;}

		[Text(Name="google_url")]
		[JsonProperty("google_url")]
		public string GoogleUrl {get; set;}

		[Text(Name="fb_chatbot_id")]
		[JsonProperty("fb_chatbot_id")]
		public string FbChatbotId {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public int? CreateTime {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public int? ModifyTime {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		public override string TableName() { return "usr_person"; }
		public static string GetIndexName() { return "db30shine_user__usr_person"; }
}
}