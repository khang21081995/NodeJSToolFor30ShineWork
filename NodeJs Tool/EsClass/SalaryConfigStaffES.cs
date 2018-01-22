using Nest;

namespace API30Shine.Models.ESModels 
{
	public class SalaryConfigStaffES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="staff_uid")]
		public string StaffUid {get; set;} 

		[Text(Name="salary_config_uid")]
		public string SalaryConfigUid {get; set;} 

		[Text(Name="fix_salary_oscillation")]
		public float FixSalaryOscillation {get; set;} 

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