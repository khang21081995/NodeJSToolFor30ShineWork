using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class SalaryStaff: TableInfo
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

		[Text(Name="salon_uid")]
		[JsonProperty("salon_uid")]
		public string SalonUid {get; set;}

		[Text(Name="fix_salary")]
		[JsonProperty("fix_salary")]
		public float? FixSalary {get; set;}

		[Text(Name="allowance_salary")]
		[JsonProperty("allowance_salary")]
		public float? AllowanceSalary {get; set;}

		[Text(Name="overtime_salary")]
		[JsonProperty("overtime_salary")]
		public float? OvertimeSalary {get; set;}

		[Text(Name="service_salary")]
		[JsonProperty("service_salary")]
		public float? ServiceSalary {get; set;}

		[Text(Name="product_salary")]
		[JsonProperty("product_salary")]
		public float? ProductSalary {get; set;}

		[Text(Name="work_day")]
		[JsonProperty("work_day")]
		public int? WorkDay {get; set;}

		[Text(Name="rating_point")]
		[JsonProperty("rating_point")]
		public float? RatingPoint {get; set;}

		[Text(Name="bill_normal")]
		[JsonProperty("bill_normal")]
		public int? BillNormal {get; set;}

		[Text(Name="bill_normal_great")]
		[JsonProperty("bill_normal_great")]
		public int? BillNormalGreat {get; set;}

		[Text(Name="bill_normal_good")]
		[JsonProperty("bill_normal_good")]
		public int? BillNormalGood {get; set;}

		[Text(Name="bill_normal_bad")]
		[JsonProperty("bill_normal_bad")]
		public int? BillNormalBad {get; set;}

		[Text(Name="bill_normal_norating")]
		[JsonProperty("bill_normal_norating")]
		public int? BillNormalNorating {get; set;}

		[Text(Name="bill_special")]
		[JsonProperty("bill_special")]
		public int? BillSpecial {get; set;}

		[Text(Name="bill_special_great")]
		[JsonProperty("bill_special_great")]
		public int? BillSpecialGreat {get; set;}

		[Text(Name="bill_special_good")]
		[JsonProperty("bill_special_good")]
		public int? BillSpecialGood {get; set;}

		[Text(Name="bill_special_bad")]
		[JsonProperty("bill_special_bad")]
		public int? BillSpecialBad {get; set;}

		[Text(Name="bill_special_norating")]
		[JsonProperty("bill_special_norating")]
		public int? BillSpecialNorating {get; set;}

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

		public override string TableName() { return "salary_staff"; }
		public static string GetIndexName() { return "db30shine_financial__salary_staff"; }
}
}