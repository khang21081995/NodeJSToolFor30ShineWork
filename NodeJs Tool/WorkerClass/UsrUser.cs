using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class UsrUser: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="person_uid")]
		[JsonProperty("person_uid")]
		public string PersonUid {get; set;}

		[Text(Name="account")]
		[JsonProperty("account")]
		public string Account {get; set;}

		[Text(Name="password")]
		[JsonProperty("password")]
		public string Password {get; set;}

		[Text(Name="last_login_time")]
		[JsonProperty("last_login_time")]
		public int? LastLoginTime {get; set;}

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

		public override string TableName() { return "usr_user"; }
		public static string GetIndexName() { return "db30shine_user__usr_user"; }
}
}