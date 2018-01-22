using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class SalaryConfig: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="staff_department_uid")]
		[JsonProperty("staff_department_uid")]
		public string StaffDepartmentUid {get; set;}

		[Text(Name="staff_level_uid")]
		[JsonProperty("staff_level_uid")]
		public string StaffLevelUid {get; set;}

		[Text(Name="staff_type_uid")]
		[JsonProperty("staff_type_uid")]
		public string StaffTypeUid {get; set;}

		[Text(Name="description")]
		[JsonProperty("description")]
		public string Description {get; set;}

		[Text(Name="fix_salary")]
		[JsonProperty("fix_salary")]
		public float? FixSalary {get; set;}

		[Text(Name="overtime_salary")]
		[JsonProperty("overtime_salary")]
		public float? OvertimeSalary {get; set;}

		[Text(Name="allowance")]
		[JsonProperty("allowance")]
		public float? Allowance {get; set;}

		[Text(Name="rating_coefficient_money")]
		[JsonProperty("rating_coefficient_money")]
		public float? RatingCoefficientMoney {get; set;}

		[Text(Name="product_bonus")]
		[JsonProperty("product_bonus")]
		public float? ProductBonus {get; set;}

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

		public override string TableName() { return "salary_config"; }
		public static string GetIndexName() { return "db30shine_financial__salary_config"; }
}
}