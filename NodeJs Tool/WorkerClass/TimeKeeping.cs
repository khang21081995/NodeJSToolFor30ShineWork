using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class TimeKeeping: TableInfo
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

		[Text(Name="time_keeper_uid")]
		[JsonProperty("time_keeper_uid")]
		public string TimeKeeperUid {get; set;}

		[Text(Name="salon_uid")]
		[JsonProperty("salon_uid")]
		public string SalonUid {get; set;}

		[Text(Name="working_shift_uid")]
		[JsonProperty("working_shift_uid")]
		public string WorkingShiftUid {get; set;}

		[Text(Name="work_date")]
		[JsonProperty("work_date")]
		public int? WorkDate {get; set;}

		[Text(Name="work_hour")]
		[JsonProperty("work_hour")]
		public float? WorkHour {get; set;}

		[Text(Name="is_enroll")]
		[JsonProperty("is_enroll")]
		public int? IsEnroll {get; set;}

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

		[Text(Name="note")]
		[JsonProperty("note")]
		public string Note {get; set;}

		public override string TableName() { return "time_keeping"; }
		public static string GetIndexName() { return "db30shine_staff__time_keeping"; }
}
}