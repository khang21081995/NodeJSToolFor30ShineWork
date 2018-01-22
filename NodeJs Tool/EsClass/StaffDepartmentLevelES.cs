using Nest;

namespace API30Shine.Models.ESModels 
{
	public class StaffDepartmentLevelES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="level_uid")]
		public string LevelUid {get; set;} 

		[Text(Name="department_uid")]
		public string DepartmentUid {get; set;} 

		[Text(Name="name")]
		public string Name {get; set;} 

		[Text(Name="description")]
		public string Description {get; set;} 

		[Text(Name="is_active")]
		public int IsActive {get; set;} 

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