using Nest;

namespace API30Shine.Models.ESModels 
{
	public class SalaryStaffES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="staff_uid")]
		public string StaffUid {get; set;} 

		[Text(Name="salon_uid")]
		public string SalonUid {get; set;} 

		[Text(Name="fix_salary")]
		public float FixSalary {get; set;} 

		[Text(Name="allowance_salary")]
		public float AllowanceSalary {get; set;} 

		[Text(Name="overtime_salary")]
		public float OvertimeSalary {get; set;} 

		[Text(Name="service_salary")]
		public float ServiceSalary {get; set;} 

		[Text(Name="product_salary")]
		public float ProductSalary {get; set;} 

		[Text(Name="work_day")]
		public int WorkDay {get; set;} 

		[Text(Name="rating_point")]
		public float RatingPoint {get; set;} 

		[Text(Name="bill_normal")]
		public int BillNormal {get; set;} 

		[Text(Name="bill_normal_great")]
		public int BillNormalGreat {get; set;} 

		[Text(Name="bill_normal_good")]
		public int BillNormalGood {get; set;} 

		[Text(Name="bill_normal_bad")]
		public int BillNormalBad {get; set;} 

		[Text(Name="bill_normal_norating")]
		public int BillNormalNorating {get; set;} 

		[Text(Name="bill_special")]
		public int BillSpecial {get; set;} 

		[Text(Name="bill_special_great")]
		public int BillSpecialGreat {get; set;} 

		[Text(Name="bill_special_good")]
		public int BillSpecialGood {get; set;} 

		[Text(Name="bill_special_bad")]
		public int BillSpecialBad {get; set;} 

		[Text(Name="bill_special_norating")]
		public int BillSpecialNorating {get; set;} 

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