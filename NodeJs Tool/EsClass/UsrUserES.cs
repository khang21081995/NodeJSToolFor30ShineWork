using Nest;

namespace API30Shine.Models.ESModels 
{
	public class UsrUserES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="person_uid")]
		public string PersonUid {get; set;} 

		[Text(Name="account")]
		public string Account {get; set;} 

		[Text(Name="password")]
		public string Password {get; set;} 

		[Text(Name="last_login_time")]
		public int LastLoginTime {get; set;} 

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