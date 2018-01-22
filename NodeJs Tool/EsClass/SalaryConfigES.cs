using Nest;

namespace API30Shine.Models.ESModels 
{
	public class SalaryConfigES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="staff_department_uid")]
		public string StaffDepartmentUid {get; set;} 

		[Text(Name="staff_level_uid")]
		public string StaffLevelUid {get; set;} 

		[Text(Name="staff_type_uid")]
		public string StaffTypeUid {get; set;} 

		[Text(Name="description")]
		public string Description {get; set;} 

		[Text(Name="fix_salary")]
		public float FixSalary {get; set;} 

		[Text(Name="overtime_salary")]
		public float OvertimeSalary {get; set;} 

		[Text(Name="allowance")]
		public float Allowance {get; set;} 

		[Text(Name="rating_coefficient_money")]
		public float RatingCoefficientMoney {get; set;} 

		[Text(Name="product_bonus")]
		public float ProductBonus {get; set;} 

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