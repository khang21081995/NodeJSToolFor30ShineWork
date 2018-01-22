using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class UsrResourceAccess: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="role_uid")]
		[JsonProperty("role_uid")]
		public string RoleUid {get; set;}

		[Text(Name="scope_uid")]
		[JsonProperty("scope_uid")]
		public string ScopeUid {get; set;}

		[Text(Name="perm_uid")]
		[JsonProperty("perm_uid")]
		public string PermUid {get; set;}

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

		public override string TableName() { return "usr_resource_access"; }
		public static string GetIndexName() { return "db30shine_user__usr_resource_access"; }
}
}