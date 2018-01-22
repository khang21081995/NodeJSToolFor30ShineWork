using Nest;

namespace API30Shine.Models.ESModels 
{
	public class UsrResourceAccessES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="role_uid")]
		public string RoleUid {get; set;} 

		[Text(Name="scope_uid")]
		public string ScopeUid {get; set;} 

		[Text(Name="perm_uid")]
		public string PermUid {get; set;} 

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