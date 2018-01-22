using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class SalaryConfigStaff: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="staff_uid")]
		[JsonProperty("staff_uid")]
		public string StaffUid {get; set;}

		[Text(Name="salary_config_uid")]
		[JsonProperty("salary_config_uid")]
		public string SalaryConfigUid {get; set;}

		[Text(Name="fix_salary_oscillation")]
		[JsonProperty("fix_salary_oscillation")]
		public float? FixSalaryOscillation {get; set;}

		[Text(Name="is_active")]
		[JsonProperty("is_active")]
		public int? IsActive {get; set;}

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

		public override string TableName() { return "salary_config_staff"; }
		public static string GetIndexName() { return "db30shine_financial__salary_config_staff"; }
}
}