using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class Staff: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="user_uid")]
		[JsonProperty("user_uid")]
		public string UserUid {get; set;}

		[Text(Name="salon_uid")]
		[JsonProperty("salon_uid")]
		public string SalonUid {get; set;}

		[Text(Name="role_uid")]
		[JsonProperty("role_uid")]
		public string RoleUid {get; set;}

		[Text(Name="staff_department_uid")]
		[JsonProperty("staff_department_uid")]
		public string StaffDepartmentUid {get; set;}

		[Text(Name="staff_level_uid")]
		[JsonProperty("staff_level_uid")]
		public string StaffLevelUid {get; set;}

		[Text(Name="staff_type_uid")]
		[JsonProperty("staff_type_uid")]
		public string StaffTypeUid {get; set;}

		[Text(Name="is_require_enroll")]
		[JsonProperty("is_require_enroll")]
		public int? IsRequireEnroll {get; set;}

		[Text(Name="bank_acc_number")]
		[JsonProperty("bank_acc_number")]
		public string BankAccNumber {get; set;}

		[Text(Name="bank_acc_owner")]
		[JsonProperty("bank_acc_owner")]
		public string BankAccOwner {get; set;}

		[Text(Name="bank_branch")]
		[JsonProperty("bank_branch")]
		public string BankBranch {get; set;}

		[Text(Name="bank_name")]
		[JsonProperty("bank_name")]
		public string BankName {get; set;}

		[Text(Name="images")]
		[JsonProperty("images")]
		public string Images {get; set;}

		[Text(Name="insurrance_number")]
		[JsonProperty("insurrance_number")]
		public string InsurranceNumber {get; set;}

		[Text(Name="join_time")]
		[JsonProperty("join_time")]
		public int? JoinTime {get; set;}

		[Text(Name="seniority_time")]
		[JsonProperty("seniority_time")]
		public int? SeniorityTime {get; set;}

		[Text(Name="level_point")]
		[JsonProperty("level_point")]
		public int? LevelPoint {get; set;}

		[Text(Name="avg_cut_time")]
		[JsonProperty("avg_cut_time")]
		public int? AvgCutTime {get; set;}

		[Text(Name="card_id_number")]
		[JsonProperty("card_id_number")]
		public string CardIdNumber {get; set;}

		[Text(Name="card_id_name")]
		[JsonProperty("card_id_name")]
		public string CardIdName {get; set;}

		[Text(Name="card_id_img_front")]
		[JsonProperty("card_id_img_front")]
		public string CardIdImgFront {get; set;}

		[Text(Name="card_id_img_back")]
		[JsonProperty("card_id_img_back")]
		public string CardIdImgBack {get; set;}

		[Text(Name="about")]
		[JsonProperty("about")]
		public string About {get; set;}

		[Text(Name="note")]
		[JsonProperty("note")]
		public string Note {get; set;}

		[Text(Name="tax_number")]
		[JsonProperty("tax_number")]
		public string TaxNumber {get; set;}

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

		public override string TableName() { return "staff"; }
		public static string GetIndexName() { return "db30shine_staff__staff"; }
}
}